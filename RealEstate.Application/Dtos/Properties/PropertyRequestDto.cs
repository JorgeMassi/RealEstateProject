using RealEstate.Domain.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Dtos.Properties
{
    public class PropertyRequestDto
    {
        public string? Description { get; set; }
        public string? Location { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }

        public Property ToEntity()
        {
            var property = new Property
            {
                Price = Price == 0 ? 0 : Price,
                Image = string.IsNullOrEmpty(Image) ? "NoImage.jpg" : Image,
                Description = string.IsNullOrEmpty(Description) ? "No description..." : Description,
                Location = string.IsNullOrEmpty(Location) ? "Localização Desconhecida..." :Location,
            };

            return property;
        }
    }

}
