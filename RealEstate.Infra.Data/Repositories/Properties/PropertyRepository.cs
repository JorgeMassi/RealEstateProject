using Microsoft.EntityFrameworkCore;
using RealEstate.Domain.Properties;
using RealEstate.Infra.Data.Repositories.ApplicationDbContext;
using RealEstate.Infra.Data.Repositories.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Infra.Data.Repositories.Properties
{
    public class PropertyRepository : Repository<Property, Guid>
    {
        public PropertyRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Property?> GetApartmentsByLocation(Guid apartmentId, CancellationToken ct)
        {
            return await DbSet.Include(apt => apt.Location).FirstOrDefaultAsync(apt => apt.Id == apartmentId, ct);
        }
    }
}
