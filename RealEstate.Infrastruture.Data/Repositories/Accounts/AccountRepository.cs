using RealEstate.Application.Interfaces.Users.Accounts;
using RealEstate.Domain.Logins;
using RealEstate.Infrastruture.Data.ApplicationDbContexts;
using RealEstate.Infrastruture.Data.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Infrastruture.Data.Repositories.Accounts
{
    public class AccountRepository : Repository<Account, Guid>, IAccountRepository
    {
        public AccountRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
