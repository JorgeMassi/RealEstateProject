using RealEstate.Domain.Entity;
using RealEstate.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Logins
{
    public class Account : BaseEntity
    {
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] SaltHash { get; set; }
        
        

        
    }
}
