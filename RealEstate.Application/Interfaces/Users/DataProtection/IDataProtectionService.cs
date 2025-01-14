using RealEstate.Domain.Logins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Interfaces.Users.DataProtection
{
    public interface IDataProtectionService
    {
        DataProtectionKeys Protect(string password);
        byte[] GetComputedHash(string password, byte[] salt);
    }
}
