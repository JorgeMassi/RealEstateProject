using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Application.Dtos.LogInDto;
using RealEstate.Application.Dtos.RegisterDto;
using RealEstate.Application.Interfaces.Users.Accounts;
using RealEstate.Application.Interfaces.Users.Roles.Users;
using RealEstate.Domain.Roles;

namespace RealEstate.Api.Controllers.Authentication
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IUserService _userService;
        private readonly ILogger<AuthenticationController> _logger;

        public AuthenticationController(IAccountService accountService, IUserService userService, ILogger<AuthenticationController> logger)
        {
            _accountService = accountService;
            _userService = userService;
            _logger = logger;
        }

        [HttpPost("login")]
        public async Task<LoginResponseDto> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            return await _accountService.Login(loginRequestDto);
        }

        [HttpPost("register")]
        public async Task<User> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            _logger.LogError($"Received Request: {Request.Body}");
            return await _userService.Create(registerRequestDto);
        }
    }
}
