using RealEstate.Domain.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Dtos.Properties
{
    public class PropertyResponseDto
    {
        public PropertyResponseDto() { }

        public PropertyResponseDto(Property property) { }
        
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Image {  get; set; }

        



    
    }


   

}
