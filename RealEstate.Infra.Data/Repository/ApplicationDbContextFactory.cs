using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Infra.Data.Repository
{
    internal class ApplicationDbContextFactory
    {
        static string? connectionString = null;

        static ApplicationDbContextFactory()
        {
            IConfiguration config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetParent(".").ToString())
               .AddJsonFile("Remedy.WebApi/appsettings.Development.json", true, true)
               .Build();

            connectionString = config["ConnectionStrings:RemedyCS"];
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
}
