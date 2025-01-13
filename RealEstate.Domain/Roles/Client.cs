using RealEstate.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Roles
{
    public class Client : BaseEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; } 
        public string? Email { get; set; } 
        public string? PhoneNumber { get; set; } 
    }
}
