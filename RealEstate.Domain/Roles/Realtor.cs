using RealEstate.Domain.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Roles
{
    public class Realtor : User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public List<Property> Properties { get; private set; } = new List<Property>();
        public Realtor(string name)
        {
            Name = name;
        }
       

    }
}
