
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Shell.NET;
using Shell.NET.Util;
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

                    // Bash($"git fetch {remote} {localBranch}");
                    if (!Bash($"git diff {localBranch} {remoteBranch}").Any())
                    {
                        Console.WriteLine("No changes");
                    }
                    else
                    {
                        Console.WriteLine(Bash($"git diff {localBranch} {remoteBranch}"));
                    }

                }
                await Task.Delay(fiveSeconds, stoppingToken);
            }
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
