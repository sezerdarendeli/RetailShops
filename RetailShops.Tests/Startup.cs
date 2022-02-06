using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RetailShops.ServiceExtensions;

namespace RetailShops.Tests
{
    public class Startup
    {
        public Startup()
        {
            var configuration = new ConfigurationBuilder();
            configuration.SetBasePath(System.IO.Directory.GetCurrentDirectory());
            configuration.AddJsonFile(path: "appsettings.json", optional: false, reloadOnChange: true);
            Configuration = configuration.Build();
        }
        public static IConfigurationRoot Configuration { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddServices(Configuration);
            services.AddSingleton<IConfiguration>(Configuration);
        }
    }
}
