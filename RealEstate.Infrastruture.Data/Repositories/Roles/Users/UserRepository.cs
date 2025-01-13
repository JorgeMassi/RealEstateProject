using Microsoft.EntityFrameworkCore;
using RealEstate.Application.Interfaces.Users.Roles.Users;
using RealEstate.Domain.Roles;
using RealEstate.Infrastruture.Data.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Infrastruture.Data.Repositories.Roles.Users
{
    public class UserRepository : Repository<User, Guid>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }

        public async Task<User?> GetByUsername(string username)
        {
            return DbSet
                .Include(x => x.Account)
                .FirstOrDefault(x => x.Account.Username == username);
        }
    }
}
