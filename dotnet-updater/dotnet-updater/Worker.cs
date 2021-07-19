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
                    _logger.LogInformation("checking if there is a new update", DateTimeOffset.Now);
                    string logMessage = "";
                    using (var repo = new Repository("../../"))
                    {
                        var remote = repo.Network.Remotes["origin"];
                        var refSpecs = remote.FetchRefSpecs.Select(x => x.Specification);
                        Commands.Fetch(repo, remote.Name, refSpecs, null, logMessage);
                        _logger.LogInformation(logMessage + "");
                        var t = "";
                    }

                    //using (var repo = new Repository("../../"))
                    //{
                    //    var branch = repo.Branches["main"];

                    //    if (branch != null)
                    //    {
                    //        FetchOptions options = new FetchOptions();
                    //        options.CredentialsProvider = new CredentialsHandler((url, usernameFromUrl, types) =>
                    //          new UsernamePasswordCredentials()
                    //          {
                    //              Username = "mo-norant",
                    //              Password = "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"
                    //          });

                    //        string logMessage = "";

                    //        var t = repo.Branches["main"].IsCurrentRepositoryHead;

                    //        if (t)
                    //        {
                    //            _logger.LogInformation("{time} > New updates available", DateTimeOffset.Now);
                    //        }else
                    //        {
                    //            _logger.LogInformation("{time} > No new updates available", DateTimeOffset.Now);
                    //        }

                    //    }
                    //}

                }

                await Task.Delay(OneMinute, stoppingToken);
            }
        }
    }
}
