using BicyclesBLL.Interfaces;
using BicyclesBLL.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BicyclesBLL
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services, string conn, IConfiguration configuration)
        {
            services.AddScoped<IBicycleService, BicycleService>();
            BicyclesDAL.Startup.ConfigureServices(services, conn, configuration);
        }
    }
}
