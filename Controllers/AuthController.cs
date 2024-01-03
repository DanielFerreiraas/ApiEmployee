using Microsoft.AspNetCore.Mvc;
using PrimeiraApi.Application.Services;

namespace PrimeiraApi.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if (username == "daniel" && password == "123456")
            {
                var token = TokenService.GenerateToken(new Domain.Model.Employee());
                return Ok(token);
            }

            return BadRequest("username or password invalid");
        }
    }
}
