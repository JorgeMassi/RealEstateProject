using RealEstate.Application.Interfaces.Generic;
using RealEstate.Domain.Logins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Interfaces.Users.Accounts
{
    public interface IAccountRepository : IRepository<Account, Guid>
    {
    }
}
