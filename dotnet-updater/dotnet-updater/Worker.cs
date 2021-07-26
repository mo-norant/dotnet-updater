
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace dotnet_updater
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> logger;
        private const bool IsCellular = true;
        private const bool CanUpdate = true;
        private const int updatePeriod = 1000 * 5;
        private const string localBranch = "main";
        private const string remoteBranch = "origin/main";
        private const string remote = "origin";

        public Worker(ILogger<Worker> logger)
        {
            this.logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (IsCellular && CanUpdate)
                {

                    Bash($"git fetch  {remote} {localBranch}");
                    if (!AnyBranchChanges())
                    {
                        logger.LogInformation("No changes");
                    }
                    else
                    {
                        logger.LogInformation("Changes detected. Applying changes...");
                        Bash($"git pull -f");
                        logger.LogInformation("Changes applied.");
                        logger.LogInformation("restarting services...");
                        RestartApplication();
                        logger.LogInformation("Service restarted.");
                    }
                }
                await Task.Delay(updatePeriod, stoppingToken);
            }
        }

        public bool AnyBranchChanges()
        {
            return Bash($"git diff --name-only {localBranch} {remoteBranch}").Any();
        }

        private void RestartApplication()
        {
            Bash("kill -9 $(sudo lsof -t -i:5001)");
            Bash("dotnet run --project /home/mo/dotnet-updater/dotnet-updater/dotnet-update-app");
        }

        public string Bash(string cmd)
        {
            var escapedArgs = cmd.Replace("\"", "\\\"");
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{escapedArgs}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
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
