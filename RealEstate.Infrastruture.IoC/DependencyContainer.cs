using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealEstate.Application.Interfaces.Properties;
using RealEstate.Application.Interfaces.UnitOfWork;
using RealEstate.Application.Services.Properties;
using RealEstate.Infrastruture.Data.Repositories.ApplicationDbContexts;
using RealEstate.Infrastruture.Data.Repositories.Properties;
using RealEstate.Infrastruture.Data.Repositories.UnitOfWork;

namespace RealEstate.Infrastruture.IoC
{
    public static class DependencyContainer
    {
        public static void AddWebApiConfigurations(this IServiceCollection services, IConfiguration config)

        {
            // Property
            services.AddScoped<IPropertyService, PropertyService>();
            services.AddScoped<IPropertyRepository, PropertyRepository>();


            services.AddScoped<DbContext, ApplicationDbContext>();



            // Database Config
            services.AddRealEstateDatabase(config);
        }

        public static IServiceCollection AddRealEstateDatabase(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                var connectionString = config.GetConnectionString("RealEstateCS");
                options.UseSqlServer(connectionString, x => x.MigrationsAssembly("RealState.Service.Api").MigrationsHistoryTable("__EFMigrationsHistory_Data"));
            });
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");


            return services;
        }
    }
}
