using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersianAnimalLand.Services.Implements;
using PersianAnimalLand.Services.Interfaces;

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
            serviceCollection.AddScoped<IUserService, UserService>();
            return serviceCollection;
        }

        public static IServiceCollection AddSingleton(this IServiceCollection serviceCollection, IConfiguration _configuration)
        {
            return serviceCollection;
        }
        public static IServiceCollection AddContext<TDbContext>(this IServiceCollection serviceCollection, string conectionString) where TDbContext : DbContext
        {
            serviceCollection.AddDbContext<TDbContext>(optionBuilder =>
            {
                optionBuilder.UseSqlServer(conectionString,
                            sqlServerOption =>
                            {
                                sqlServerOption.MaxBatchSize(1000);
                                sqlServerOption.CommandTimeout(null);
                                sqlServerOption.UseRelationalNulls(false);
                            });
            });

            return serviceCollection;
        }
    }
}
