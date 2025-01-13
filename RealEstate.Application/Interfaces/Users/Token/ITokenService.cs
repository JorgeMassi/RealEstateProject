using RealEstate.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Interfaces.Users.Token
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
