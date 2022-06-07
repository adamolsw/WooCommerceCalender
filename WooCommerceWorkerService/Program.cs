using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WooCommerceWorkerService.Services;

namespace WooCommerceWorkerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseWindowsService()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                });


        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            //services.AddLogging(builder => builder.AddNLog("nlog.config"));

            services.AddScoped<IDbService, DbService>()
                    .AddScoped<IWooCommerceService, WooCommerceService>()
                    .AddScoped<IProcessService, ProcessService>();

            return services.BuildServiceProvider();
        }
    }
}
