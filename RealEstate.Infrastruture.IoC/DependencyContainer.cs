using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using RealEstate.Application.Interfaces.Properties;
using RealEstate.Application.Interfaces.UnitOfWork;
using RealEstate.Application.Interfaces.Users.DataProtection;
using RealEstate.Application.Interfaces.Users.Roles.Users;
using RealEstate.Application.Interfaces.Users.Token;
using RealEstate.Application.Services.Properties;
using RealEstate.Application.Services.Users.DataProtection;
using RealEstate.Application.Services.Users.Roles;
using RealEstate.Application.Services.Users.Tokens;
using RealEstate.Infrastruture.Data.ApplicationDbContexts;
using RealEstate.Infrastruture.Data.Repositories.Properties;
using RealEstate.Infrastruture.Data.Repositories.Roles.Users;
using RealEstate.Infrastruture.Data.UnitOfWork;
using System.Text;

namespace RealEstate.Infrastruture.IoC
{
    public static class DependencyContainer
    {
        public static void AddWebApiConfigurations(this IServiceCollection services, IConfiguration configuration)

        {
            // Property
            services.AddScoped<IPropertyRepository, PropertyRepository>();
            services.AddScoped<IPropertyService, PropertyService>();

            // User
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();


            services.AddScoped<IDataProtectionService, DataProtectionService>();

            services.AddJwtAuthentication(configuration);


            services.AddScoped<DbContext, ApplicationDbContext>();

            // AutoMapper Configuration
            services.AddAutoMapperDependency(configuration);

            // Database Config
            services.AddRealEstateDatabase(configuration);
        }

        public static IServiceCollection AddRealEstateDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("RealEstateCS");
                options.UseSqlServer(connectionString, x => x.MigrationsAssembly("RealState.Service.Api").MigrationsHistoryTable("__EFMigrationsHistory_Data"));
            });
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");


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
        public static IServiceCollection AddAutoMapperDependency(this IServiceCollection services, IConfiguration config)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }

        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                //CreateMap<Proper, ApartmentRequestDto>();
                //CreateMap<ApartmentRequestDto, Apartment>();
                //CreateMap<Location, LocationResponseDto>();
                //CreateMap<LocationResponseDto, Location>();
            }
        }


    }
}
