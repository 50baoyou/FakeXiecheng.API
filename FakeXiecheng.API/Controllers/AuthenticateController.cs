using FakeXiecheng.API.Dtos;
using FakeXiecheng.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FakeXiecheng.API.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IAuthenticateService _authenticateService;

        public AuthenticateController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto loginDto)
        {
            // 1.验证用户名密码

            // 2.创建JWT

            // 3.返回200+JWT
            var token = _authenticateService.CreateJwtToken(loginDto.Email);

            return Ok(token);
        }
    }
}
