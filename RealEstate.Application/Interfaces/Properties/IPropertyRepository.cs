using RealEstate.Application.Interfaces.Generic;
using RealEstate.Domain.Logins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Interfaces.Properties
{
    public interface IPropertyRepository: IRepository<Account,Guid>
    {
    }
}
