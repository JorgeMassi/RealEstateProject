using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Infrastruture.Data.Repositories.ApplicationDbContexts
{
    internal class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        static string? connectionString = null;

        static ApplicationDbContextFactory()
        {
            IConfiguration config = new ConfigurationBuilder()
               //.SetBasePath(Directory.GetCurrentDirectory())
               //.AddJsonFile("appsettings.Development.json", true, true)
               //.Build();
               .SetBasePath(Directory.GetParent(".").ToString())
               .AddJsonFile("RealEstate.Api/appsettings.Development.json", true, true)
                .Build();

            connectionString = config["ConnectionStrings:RealEstateCS"];
            Console.WriteLine("ConnectionString:" + connectionString);
        }


        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
