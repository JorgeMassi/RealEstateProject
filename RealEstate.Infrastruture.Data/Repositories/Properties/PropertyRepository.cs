using Microsoft.EntityFrameworkCore;
using RealEstate.Application.Interfaces.Properties;
using RealEstate.Domain.Properties;
using RealEstate.Infrastruture.Data.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Infrastruture.Data.Repositories.Properties
{
    public class PropertyRepository : Repository<Property, Guid>, IPropertyRepository   
    {
        public PropertyRepository(DbContext context) : base(context)
        {
        }
    }
}
