using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace dotnet_updater
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                    services.AddLogging(opt =>
                     {
                         opt.AddConsole(c =>
                         {
                             opt.AddSimpleConsole(options => options.TimestampFormat = "[HH:mm:ss] ");
                         });
                     });

                })
            ;
    }
}
