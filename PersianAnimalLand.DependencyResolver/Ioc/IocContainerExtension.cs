using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PersianAnimalLand.DependencyResolver.Ioc
{
    public static class IocContainerExtension
    {
        public static IServiceCollection AddTransient(this IServiceCollection serviceCollection, IConfiguration _configuration)
        {
            return serviceCollection;
        }

        public static IServiceCollection AddScope(this IServiceCollection serviceCollection, IConfiguration _configuration)
        {
            return serviceCollection;
        }

        public static IServiceCollection AddSingleton(this IServiceCollection serviceCollection, IConfiguration _configuration)
        {
            return serviceCollection;
        }
    }
}
