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
                    _logger.LogInformation("{time}: checking if there is a new update", DateTimeOffset.Now);

                    string logMessage = "";
                    using (var repo = new Repository("../../"))
                    {
                        var branch = repo.Branches.FirstOrDefault(x => x.FriendlyName == "main");
                        if (branch.TrackingDetails.AheadBy != null)
                        {
                            foreach (var commit in repo.Commits.Take(branch.TrackingDetails.AheadBy.Value))
                            {
                                _logger.LogInformation(commit.Id.ToString());
                            }
                        }
                    }
                    _logger.LogInformation(logMessage);
                }

                await Task.Delay(OneMinute, stoppingToken);
            }
        }
    }
}
