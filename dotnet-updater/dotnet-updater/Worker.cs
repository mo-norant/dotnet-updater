
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Shell.NET;
using Shell.NET.Util;
using System;
using System.Diagnostics;
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

                    Bash($"git fetch {remote} {localBranch}");
                    Bash("git rev-parse --abbrev-ref --symbolic-full-name @{u}");

                }
                await Task.Delay(fiveSeconds, stoppingToken);
            }
        }



        public string Bash(string cmd)
        {
<<<<<<< HEAD
            var escapedArgs = cmd.Replace("\"", "\\\"");

            var process = new Process()
=======
            BashResult result = bash.Command(command);
            //mo
            if (result.ErrorMsg.Length > 0)
>>>>>>> 587c2160e35d8dad056525940908ae3dd8051b1b
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
