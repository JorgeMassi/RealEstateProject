using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Application.Interfaces.Users.Roles.Users;
using RealEstate.Domain.Roles;

namespace RealEstate.Api.Controllers.Roles
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _userService.GetAll());
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _userService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            return Ok(await _userService.Create(user));
        }

        [HttpPut]
        public async Task<IActionResult> Update(User user)
        {
            return Ok(await _userService.Update(user));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(User user)
        {
            return Ok(await _userService.Delete(user));
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await _userService.Delete(id));
        }
    }
}
