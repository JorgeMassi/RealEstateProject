using RealEstate.Application.Dtos.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Interfaces.Properties
{
    public interface IPropertyService
    {
        Task<IEnumerable<PropertyResponseDto>> GetAll();
        Task<PropertyResponseDto> GetById(Guid id);
        Task<PropertyResponseDto> Create(PropertyRequestDto property);
        Task<PropertyResponseDto> Update(PropertyRequestDto property);
        Task<PropertyResponseDto> Delete(PropertyDeleteRequestDto property);
        Task<PropertyResponseDto> Delete(Guid id);
    }
}
