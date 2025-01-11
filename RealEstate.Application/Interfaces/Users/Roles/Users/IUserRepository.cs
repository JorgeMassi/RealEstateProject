using RealEstate.Application.Interfaces.Generic;
using RealEstate.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Interfaces.Users.Roles.Users
{
    public interface IUserRepository : IRepository<User, Guid>
    {
        public Task<User> GetByUsername(string username);
    }
}
