
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Shell.NET;
using Shell.NET.Util;
using System;
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
        private const int fiveSeconds = 1000 * 5;
        private string latestCommit = "";

        private const string localBranch = "main";
        private const string remoteBranch = "origin/main";
        private const string remote = "origin";
        private Bash bash = new Bash();

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

                    RunCommand($"git fetch {remote} {localBranch}");

                }
                await Task.Delay(fiveSeconds, stoppingToken);
            }
        }

        private string RunCommand(string command)
        {
            BashResult result = bash.Command(command);

            if (result.ErrorMsg.Length > 0)
            {
                throw new Exception(result.ErrorMsg);
            }

            return result.Output;
        }
    }
}
