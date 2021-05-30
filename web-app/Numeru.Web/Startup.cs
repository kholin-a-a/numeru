using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Numeru.Numerologic;
using Numeru.Services;
using System;
using System.Collections.Generic;
using System.IO;

namespace Numeru.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            this._env = env;
        }

        public IConfiguration Configuration { get; }

        private readonly IWebHostEnvironment _env;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddScoped<AbstractEvaluator, BaseEvaluator>();

            services.AddScoped<INumberService, NumberService>();
            services.AddScoped<IAlphabet, RussianAlphabet>();
            services.AddScoped<IEvaluationTracer, EvaluationTracer>();

            services.AddScoped<IEvaluationAlgorithm<DateTime>, DateTimeAlgorithm>();
            services.AddScoped<IEvaluationAlgorithm<Person>, PersonAlgorithm>();

            var predictions = JsonConvert.DeserializeObject<IEnumerable<string>>(
                File.ReadAllText(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/predictions.json")
                    )
                );

            services.AddScoped<IPredictionRepository>(sp =>
                new InMemoryPredictionRepository(predictions)
            );

            var destinies = JsonConvert.DeserializeObject<IEnumerable<string>>(
                File.ReadAllText(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/destiny.json")
                    )
                );

            services.AddScoped<IDestinyRepository>(sp =>
                new InMemoryDestinyRepository(destinies)
            );

            services.AddWebOptimizer(
                minifyCss: !this._env.IsDevelopment(),
                minifyJavaScript: !this._env.IsDevelopment()
                );

            services.AddScoped<IDateTimeProvider, MoscowDateTimeProvider>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseWebOptimizer();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}");
            });
        }
    }
}
