using ETicaretAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistance
{
    public static class ServiceRegistration
    {


        public static void AddPersistenceServices(this IServiceCollection services)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json");
            IConfiguration _configuration = builder.Build();

            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("MsSql")));
        }
    }
}
