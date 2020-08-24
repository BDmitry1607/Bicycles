using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using BicyclesDAL.Interfaces;
using BicyclesDAL.Repositories;

namespace BicyclesDAL
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services, string connection, IConfiguration configuration)
        {
            services.AddDbContext<StoreContext>(options => options.UseSqlServer(connection));
            services.AddScoped<IBicycleRepository, BicycleRepository>();
        }
    }
}
