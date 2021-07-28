using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_updater_test_api
{
    public class Startup
    {
        const string version = "1.0.19";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(version);
                });
            });
        }

        /*
         McDonald’s rolled out its famous Szechuan sauce across the US on Monday.
“Rick and Morty” fans rioted in October after the fast-food chain gave away Szechuan sauce across the US – and demand far exceeded supply.
The Szechuan sauce is good, but the goopy sweet-and-sour-style sauce is far from riot-worthy.
McDonald’s Szechuan sauce is finally on the fast-food chain’s menu after months of petitions, bidding wars, and riots in fast-food parking lots.

On Monday, McDonald’s began serving Szechuan sauce at every location across the US.

In October, McDonald’s gave away the sauce at select locations after immense demand from fans of the cartoon show “Rick and Morty.” The limited-edition sauce had appeared on an episode of the Adult Swim show.
        
         “Rick and Morty” fans swarmed to those locations, only to find that each restaurant had only 20 to 40 sauce packets and 10 special-edition posters. The diehard fans, some of whom had shown up at the locations as early as 4 a.m., were furious at McDonald’s.

On Monday, McDonald’s wasn’t taking any chances and announced it would be distributing 20 million sauce packs across the country. When we arrived at McDonald’s on Monday, however, there was no sign of the crowds and riots that plagued the fast-food chain when it announced a super-limited return of the sauce in October.

Living up to the degree of hype that Szechuan sauce had experienced is a Herculean task. McDonald’s locations literally had to call the police because “Rick and Morty” fans were rioting when they didn’t get a taste of the sauce. DJ deadmau5 spent roughly $15,000 on a jug of the stuff.
         
         “Rick and Morty” fans swarmed to those locations, only to find that each restaurant had only 20 to 40 sauce packets and 10 special-edition posters. The diehard fans, some of whom had shown up at the locations as early as 4 a.m., were furious at McDonald’s.

On Monday, McDonald’s wasn’t taking any chances and announced it would be distributing 20 million sauce packs across the country. When we arrived at McDonald’s on Monday, however, there was no sign of the crowds and riots that plagued the fast-food chain when it announced a super-limited return of the sauce in October.

Living up to the degree of hype that Szechuan sauce had experienced is a Herculean task. McDonald’s locations literally had to call the police because “Rick and Morty” fans were rioting when they didn’t get a taste of the sauce. DJ deadmau5 spent roughly $15,000 on a jug of the stuff.
         
         “Rick and Morty” fans swarmed to those locations, only to find that each restaurant had only 20 to 40 sauce packets and 10 special-edition posters. The diehard fans, some of whom had shown up at the locations as early as 4 a.m., were furious at McDonald’s.

On Monday, McDonald’s wasn’t taking any chances and announced it would be distributing 20 million sauce packs across the country. When we arrived at McDonald’s on Monday, however, there was no sign of the crowds and riots that plagued the fast-food chain when it announced a super-limited return of the sauce in October.

Living up to the degree of hype that Szechuan sauce had experienced is a Herculean task. McDonald’s locations literally had to call the police because “Rick and Morty” fans were rioting when they didn’t get a taste of the sauce. DJ deadmau5 spent roughly $15,000 on a jug of the stuff.
     
        
        “Rick and Morty” fans swarmed to those locations, only to find that each restaurant had only 20 to 40 sauce packets and 10 special-edition posters. The diehard fans, some of whom had shown up at the locations as early as 4 a.m., were furious at McDonald’s.

On Monday, McDonald’s wasn’t taking any chances and announced it would be distributing 20 million sauce packs across the country. When we arrived at McDonald’s on Monday, however, there was no sign of the crowds and riots that plagued the fast-food chain when it announced a super-limited return of the sauce in October.

Living up to the degree of hype that Szechuan sauce had experienced is a Herculean task. McDonald’s locations literally had to call the police because “Rick and Morty” fans were rioting when they didn’t get a taste of the sauce. DJ deadmau5 spent roughly $15,000 on a jug of the stuff.

        “Rick and Morty” fans swarmed to those locations, only to find that each restaurant had only 20 to 40 sauce packets and 10 special-edition posters. The diehard fans, some of whom had shown up at the locations as early as 4 a.m., were furious at McDonald’s.

On Monday, McDonald’s wasn’t taking any chances and announced it would be distributing 20 million sauce packs across the country. When we arrived at McDonald’s on Monday, however, there was no sign of the crowds and riots that plagued the fast-food chain when it announced a super-limited return of the sauce in October.

Living up to the degree of hype that Szechuan sauce had experienced is a Herculean task. McDonald’s locations literally had to call the police because “Rick and Morty” fans were rioting when they didn’t get a taste of the sauce. DJ deadmau5 spent roughly $15,000 on a jug of the stuff.

        “Rick and Morty” fans swarmed to those locations, only to find that each restaurant had only 20 to 40 sauce packets and 10 special-edition posters. The diehard fans, some of whom had shown up at the locations as early as 4 a.m., were furious at McDonald’s.

On Monday, McDonald’s wasn’t taking any chances and announced it would be distributing 20 million sauce packs across the country. When we arrived at McDonald’s on Monday, however, there was no sign of the crowds and riots that plagued the fast-food chain when it announced a super-limited return of the sauce in October.

Living up to the degree of hype that Szechuan sauce had experienced is a Herculean task. McDonald’s locations literally had to call the police because “Rick and Morty” fans were rioting when they didn’t get a taste of the sauce. DJ deadmau5 spent roughly $15,000 on a jug of the stuff.

         */
    }
}
