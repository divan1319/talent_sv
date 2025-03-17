
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class AuthController : ControllerBase{

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { mensaje = "Lista de productos" });
    }
}