using eReconcilition.Business.Abstract;
using eReconcilition.Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eReconcilition.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register (UserForRegister userForRegister)
        {
            var userExists = _authService.UserExists(userForRegister.Email);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _authService.Register(userForRegister, userForRegister.Password);
            var result = _authService.CreateAccessToken(registerResult.Data, 0);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            //if (registerResult.Success)
            //{
            //    return Ok(registerResult);
            //}

            return BadRequest(registerResult.Message);
        }
    }
}
