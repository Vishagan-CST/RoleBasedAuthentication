using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiWithRoles.Controllers
{
    [Authorize(Roles = "User")]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("You can access the user controller");
        }
    }
}
