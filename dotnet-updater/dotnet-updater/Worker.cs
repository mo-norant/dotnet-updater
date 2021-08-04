
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace dotnet_updater
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> logger;
        private readonly IConfiguration configuration;
        private readonly bool IsCellular;
        private readonly bool CanUpdate;
        private readonly int interval;
        public Worker(ILogger<Worker> logger, IConfiguration configuration)
        {
            this.logger = logger;
            this.configuration = configuration;
            interval = 1000 * configuration.GetValue("UpdateInterval", 60);
            CanUpdate = configuration.GetValue("CanUpdate", false);
            IsCellular = configuration.GetValue("IsCellular", false);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            logger.LogInformation("Check updates on {} branch", configuration["ReleaseRepository"]);
            logger.LogInformation("Check for update every {} seconds", interval/1000);

            while (!stoppingToken.IsCancellationRequested)
            {
                if (IsCellular && CanUpdate)
                {
                    Bash($"git fetch  {configuration["UpstreamName"]} {configuration["ReleaseRepository"]}");
                    if (AnyBranchChanges())
                    {
                        logger.LogInformation("Changes detected. Applying changes...");
                        string output = Bash($"git pull -X theirs -f -s recursive --stat {configuration["UpstreamName"]} {configuration["ReleaseRepository"]} ");
                        logger.LogInformation(output);
                        logger.LogInformation("Changes applied.");
                    }
                    else
                    {
                        logger.LogInformation("No changes");
                    }
                } 
                else if (!IsCellular) logger.LogWarning("Can't update trough cellular");
                else if (!CanUpdate) logger.LogWarning("Update is not allowed");
                
                logger.LogInformation("Check new update at: {date}", DateTime.Now.AddSeconds(interval).ToString("dddd, dd MMMM yyyy HH: mm:ss"));
                await Task.Delay(interval, stoppingToken);
            }
        }

        public bool AnyBranchChanges()
        {
            return Bash($"git diff --name-only {configuration["ReleaseRepository"]} {configuration["UpstreamName"]}/{configuration["ReleaseRepository"]}").Any();
        }

        public string Bash(string cmd, bool UseShellExecute = false)
        {
            var escapedArgs = cmd.Replace("\"", "\\\"");
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{escapedArgs}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = UseShellExecute,
                    CreateNoWindow = true,
                }
            };
            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return result;
        }

    }
}
