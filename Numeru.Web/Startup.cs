using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Numeru.Services;
using System;
using System.Collections.Generic;
using System.IO;

namespace Numeru.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddScoped<INumberService, NumberService>();
            services.AddScoped<IKindDefinder, NumberKindDefinder>();
            services.AddScoped<IDescriptionRepository, NumberDescriptionRepository>();
            services.AddScoped<IEvaluationAlgorithm<DateTime>, DateAlgorithm>();

            var predictions = JsonConvert.DeserializeObject<IEnumerable<string>>(
                File.ReadAllText(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/predictions.json")
                    )
                );

            services.AddScoped<IPredictionRepository>(sp =>
                new InMemoryPredictionRepository(predictions)
            );

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Moment}/{action=Index}");
            });
        }
    }
}
