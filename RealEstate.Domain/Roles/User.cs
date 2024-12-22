using RealEstate.Domain.Entity;
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
        public string? PasswordHash { get; set; } 
        public Role Role { get; set; }
    }
    public enum Role
    {
        Admin,
        Broker,
        Manager,
        Realtor,
        RegisteredUser,
        UnregisteredUser
    }
}
