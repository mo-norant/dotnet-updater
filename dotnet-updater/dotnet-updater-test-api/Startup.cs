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
        const string version = "1.0.22";

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
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         The Reagan Doctrine was stated by United States President Ronald Reagan in his State of the Union address on February 6, 1985: "We must not break faith with those who are risking their lives--on every continent from Afghanistan to Nicaragua葉o defy Soviet-supported aggression and secure rights which have been ours from birth."[1] It was a strategy implemented by the Reagan Administration to overwhelm the global influence of the Soviet Union in the late Cold War. The doctrine was a centerpiece of United States foreign policy from the early 1980s until the end of the Cold War in 1991.

Under the Reagan Doctrine, the United States provided overt and covert aid to anti-communist guerrillas and resistance movements in an effort to "roll back" Soviet-backed pro-communist governments in Africa, Asia, and Latin America. The doctrine was designed to diminish Soviet influence in these regions as part of the administration's overall strategy to win the Cold War.
        
         */
    }
}
