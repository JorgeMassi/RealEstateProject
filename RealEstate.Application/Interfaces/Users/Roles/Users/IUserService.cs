using RealEstate.Application.Dtos.RegisterDto;
using RealEstate.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Interfaces.Users.Roles.Users
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(Guid id);
        Task<User> GetByUsername(string username);
        Task<User> Create(RegisterRequestDto registerRequestDto);
        Task<User> Create(User user);
        Task<User> Update(User user);
        Task<User> Delete(User user);
        Task<User> Delete(Guid id);
    }
}
