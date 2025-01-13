using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Properties
{
    public class Listing
    {
        public int Id { get; private set; }
        public List<Property>? Propertys { get; private set; }
    }
    
}
