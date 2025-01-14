using RealEstate.Application.Dtos.LogInDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Interfaces.Users.Accounts
{
    public interface IAccountService
    {
        public Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
    }
}

