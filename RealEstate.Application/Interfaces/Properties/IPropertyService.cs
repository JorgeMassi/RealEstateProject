using RealEstate.Application.Interfaces.Generic;
using RealEstate.Domain.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Interfaces.Properties
{
    public interface IPropertyService : IService<Property, Guid>
    {
        Task<IEnumerable<Property>> GetAll();
        Task<Property> GetById(Guid id);
        Task<Property> Create(Property property);
        Task<Property> Update(Property property);
        Task<Property> Delete(Property property);
        Task<Property> Delete(Guid id);
    }
}
