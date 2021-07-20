using LibGit2Sharp;
using LibGit2Sharp.Handlers;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Shell.NET;
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
                    using (var repo = new Repository("../../"))
                    {
                        PullOptions options = new PullOptions();
                        options.FetchOptions = new FetchOptions();
                        
                        var signature = new Signature(
                            new Identity("MERGE_USER_NAME", "MERGE_USER_EMAIL"), DateTimeOffset.Now);

                        // Pull
                        Commands.Pull(repo, signature, options);
                        Commit commit = repo.Commits.FirstOrDefault();

                        if(!string.Equals(commit.Sha, latestCommit))
                        {
                            latestCommit = commit.Sha;
                            logger.LogInformation("Latest commit: {sha}", latestCommit);
                            logger.LogInformation("Message: {message}", commit.MessageShort);

                            var bash = new Bash();
                            logger.LogInformation(bash.Command("sudo kill -9 $(sudo lsof -t -i:5000)").Output);
                            logger.LogInformation(bash.Command("sudo kill -9 $(sudo lsof -t -i:5001)").Output);
                            logger.LogInformation(bash.Command("dotnet run --project /home/mo/dotnet-updater/dotnet-updater/dotnet-update-app").Output);

                        }

                    }
                }
                await Task.Delay(fiveSeconds, stoppingToken);
            }
        }
    }
}
