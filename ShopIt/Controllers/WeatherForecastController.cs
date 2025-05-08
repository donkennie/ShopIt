using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopIt.DTOs;
using ShopIt.Services;

namespace ShopIt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistrationController : ControllerBase
    {
        private readonly RegistrationService _registrationService;
        private readonly LoginService _loginService;

        public RegistrationController(RegistrationService registrationService, LoginService loginService)
        {
            _registrationService = registrationService;
            _loginService = loginService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDTO dto)
        {
            try
            {
                var message = await _registrationService.RegisterAsync(dto);
                return Ok(new { message });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("login")]
        [Authorize]
        public async Task<IActionResult> Login(LoginDTO dto)
        {
            try
            {
                // var token = await _loginService.LoginAsync(dto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

    }
}
