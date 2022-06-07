using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WooCommerceWorkerService.Services;

namespace WooCommerceApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            var serviceProvider = ConfigureServices();
            var processService = serviceProvider.GetService<IProcessService>();
            var dbService = serviceProvider.GetService<IDbService>();
            await processService.RunAsync();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }


        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            //services.AddLogging(builder => builder.AddNLog("nlog.config"));

            services.AddScoped<IDbService, DbService>()
                    .AddScoped<IWooCommerceService, WooCommerceService>()
                    .AddScoped<IProcessService, ProcessService>();
            services.AddTransient<Form1>();
            services.AddTransient<DayDetails>();
            services.AddTransient<UserControlDays>();

            return services.BuildServiceProvider();
        }
    }
}
