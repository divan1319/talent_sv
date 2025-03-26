using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Talent_SV.Dto;
using Talent_SV.Entities;

namespace Talent_SV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user = new ();
        
        [HttpPost("register")]
        public ActionResult<User> Register(UserDto userDto)
        {
            var hashedPass = new PasswordHasher<User>().HashPassword(user, userDto.Password);

            user.Password = hashedPass;

            return Ok(user);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { mensaje = "Lista de productos" });
        }
    }
}