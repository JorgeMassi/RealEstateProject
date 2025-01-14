using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
   
        private readonly ILogger<AuthenticationController> _logger;

        public AuthenticationController(ILogger<AuthenticationController> logger)
        {
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
