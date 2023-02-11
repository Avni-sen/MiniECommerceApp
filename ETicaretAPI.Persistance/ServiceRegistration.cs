using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Persistance.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService ,ProductService>();   
        }
    }
}
