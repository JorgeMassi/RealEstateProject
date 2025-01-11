using RealEstate.Domain.Entity;
using RealEstate.Domain.Logins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Roles
{
    public class User : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public Account? Account { get; set; }
        public Role Role { get; set; }
    }
    public enum Role
    {
        AdminUser,
        Broker,
        Manager,
        Realtor,
        RegisteredUser,
        UnregisteredUser
    }
}
