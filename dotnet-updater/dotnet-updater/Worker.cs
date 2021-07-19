using LibGit2Sharp;
using LibGit2Sharp.Handlers;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace dotnet_updater
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        private const bool IsCellular = true;
        private const int OneMinute = 1000 * 60;


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
                    _logger.LogInformation("checking if there is a new update", DateTimeOffset.Now);

                    using (var repo = new Repository("."))
                    {
                        var branch = repo.Branches["production"];

                        if (branch != null)
                        {
                            string logMessage = "";
                            FetchOptions options = new FetchOptions();
                            options.CredentialsProvider = new CredentialsHandler((url, usernameFromUrl, types) =>
                              new UsernamePasswordCredentials()
                              {
                                  Username = "USERNAME",
                                  Password = "PASSWORD"
                              });

                            foreach (Remote remote in repo.Network.Remotes)
                            {
                                IEnumerable<string> refSpecs = remote.FetchRefSpecs.Select(x => x.Specification);
                                Commands.Fetch(repo, remote.Name, refSpecs, options, logMessage);
                            }

                            Console.WriteLine(logMessage);

                        }
                    }

                }


                _logger.LogInformation("OVC Update tool check at: {time}", DateTimeOffset.Now);
                await Task.Delay(OneMinute, stoppingToken);
            }
        }
    }
}
