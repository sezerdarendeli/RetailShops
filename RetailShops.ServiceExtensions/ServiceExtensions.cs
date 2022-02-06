
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RetailShops.Data;
using RetailShops.Repositories.Contracts;
using RetailShops.Repositories.Interfaces;

namespace RetailShops.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
            services.AddScoped(typeof(IInvoiceRepository), typeof(InvoiceRepository));
            services.AddScoped(typeof(IDiscountCountRepository), typeof(DiscountTypeRepository));
         


            return services;
        }

        public static void ConfigureSqlServer(this IServiceCollection services, IConfiguration configuration) =>
         services.AddDbContext<ApplicationContextDb>(options =>
         options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
    }
}
