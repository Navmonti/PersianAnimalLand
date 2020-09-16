using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersianAnimalLand.Core.EF.Repository;
using PersianAnimalLand.Core.Repository;
using PersianAnimalLand.DataAccess.Context; 
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
            #region Context
            serviceCollection.AddContext<PersianAnimalLandContext>(_configuration.GetConnectionString("PersianAnimalLandContext"));
            #endregion

            #region Services
            serviceCollection.AddScoped<IUserService, UserService>();
            #endregion

            #region Repos
            serviceCollection.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
            #endregion

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
                optionBuilder.UseSqlServer(conectionString);
            });

            return serviceCollection;
        }
    }
}
