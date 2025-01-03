using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Dtos.Properties
{
    public class PropertyDeleteRequestDto
    {
        public PropertyDeleteRequestDto(Guid Id) 
        {
            this.Id = Id;
        }
        public Guid Id { get; set; }
    }
}
