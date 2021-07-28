
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
        private const bool IsCellular = true;
        private const bool CanUpdate = true;
        private const int updatePeriod = 1000 * 5;
        private const string localBranch = "main";
        private const string remoteBranch = "origin/main";
        private const string remote = "origin";
        private const int applicationPort = 5001;

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
                    if (AnyBranchChanges())
                    {
                        logger.LogInformation("Changes detected. Applying changes...");
                        string output = Bash($"git pull -f --stat");
                        logger.LogInformation(output);
                        logger.LogInformation("Changes applied.");
                        logger.LogInformation("There is {x}KB changed.", GetByteChangesBetweenLatestCommits() / 1000);
                    }
                    else
                    {
                        logger.LogInformation("No changes");
                    }
                }
                logger.LogInformation("Check new update at: {date}", DateTime.Now.AddSeconds(updatePeriod).ToString("dddd, dd MMMM yyyy HH: mm:ss"));
                await Task.Delay(updatePeriod, stoppingToken);
            }
        }

        public bool AnyBranchChanges()
        {
            return Bash($"git diff --name-only {localBranch} {remoteBranch}").Any();
        }

        public long GetByteChangesBetweenLatestCommits()
        {
            string bytes = Bash("bash ../../../git-file-size-diff.sh  HEAD..HEAD~1 | tail -1 | grep -o '[[:digit:]]*' ");
            return long.Parse(bytes);
        }

        private void RestartApplication()
        {
            logger.LogWarning("applying update script");
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
