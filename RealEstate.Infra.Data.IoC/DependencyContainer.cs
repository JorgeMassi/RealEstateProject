using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealEstate.Application.Interfaces.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RealEstate.Infra.Data.IoC
{
    public class DependencyContainer
    {
        public static void AddWebApiConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            // Using CQRS
            //services.AddApplicationServices();

            // Property
            services.AddScoped<IPropertyRepository, PropertyRepository>();
            services.AddScoped<IPropertyService, PorpertyService>();



            // Database Config
            services.AddRemedyDatabase(configuration);

            // Authentication
            services.AddJwtAuthentication(configuration);

            // AutoMapper Configuration
            services.AddAutoMapperDependency(configuration);
        }

        public static IServiceCollection AddRealEstateDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("RemedyCS");
                options.UseSqlServer(connectionString, x => x.MigrationsAssembly("Remedy.Services.WebApi").MigrationsHistoryTable("__EFMigrationsHistory_Data"));
            });
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            // TODO: Seed data
            // if (environment.ToLower() == "development") 
            //    services.AddScoped<DbInitializer>();

            return services;
        }

        public static IServiceCollection AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IDataProtectionService, DataProtectionService>();
            services.AddScoped<ITokenService, TokenService>();

            services.AddAuthentication()
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = configuration["JwtSettings:Issuer"]!,
                        ValidateAudience = true,
                        ValidAudience = configuration["JwtSettings:Audience"]!,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]!)),
                    };
                });

            return services;
        }
    }
}
