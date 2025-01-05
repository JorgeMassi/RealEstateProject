using Microsoft.EntityFrameworkCore;
using RealEstate.Domain.Properties;
using RealEstate.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Infrastruture.Data.Repositories.ApplicationDbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Property> Properties { get; set; }
        //public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
