using LibGit2Sharp;
using LibGit2Sharp.Handlers;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace dotnet_updater
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        private const bool IsCellular = true;
        private const int OneMinute = 1000 * 15;


        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (IsCellular)
                {
                    using (var repo = new Repository("../../"))
                    {
                        
                        PullOptions options = new PullOptions();
                        options.FetchOptions = new FetchOptions();
                        //options.FetchOptions.CredentialsProvider = new CredentialsHandler(
                        //    (url, usernameFromUrl, types) =>
                        //        new UsernamePasswordCredentials()
                        //        {
                        //            Username = "mo.bouzim@live.be",
                        //            Password = ""
                        //        });

                        // User information to create a merge commit
                        var signature = new Signature(
                            new Identity("MERGE_USER_NAME", "MERGE_USER_EMAIL"), DateTimeOffset.Now);

                        // Pull
                        Commands.Pull(repo, signature, options);
                    }
                }
                await Task.Delay(OneMinute, stoppingToken);
            }
        }
    }
}
