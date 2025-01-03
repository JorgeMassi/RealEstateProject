using RealEstate.Application.Dtos.Properties;
using RealEstate.Application.Interfaces.Generic;
using RealEstate.Application.Interfaces.Properties;
using RealEstate.Domain.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Services.Properties
{
    public class PropertyService : IPropertyService
    {
        public readonly IPropertyRepository _propertyRepository;

        public PropertyService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        public Task<PropertyResponseDto> Create(PropertyRequestDto property)
        {
            throw new NotImplementedException();
        }

        public Task<PropertyResponseDto> Delete(PropertyDeleteRequestDto property)
        {
            throw new NotImplementedException();
        }

        public Task<PropertyResponseDto> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PropertyResponseDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PropertyResponseDto> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PropertyResponseDto> Update(PropertyRequestDto property)
        {
            throw new NotImplementedException();
        }
    }
}
