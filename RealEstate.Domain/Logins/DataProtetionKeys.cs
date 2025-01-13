using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Logins
{
    public record DataProtectionKeys(byte[] PasswordHash, byte[] PasswordSalt);

}
