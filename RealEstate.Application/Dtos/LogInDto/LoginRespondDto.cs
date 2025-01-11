using RealEstate.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Dtos.LogInDto
{
    public class LoginResponseDto
    {
        public User User { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
