using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Roles
{
    public class Manager : Realtor
    {
        public List<Realtor> Team { get; private set; } = new List<Realtor>();

        public Manager(string name): base(name) { }
    }
}
