using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiWithRoles.Controllers
{
    [Authorize(Roles = "Admin")]
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("You can access the admin controller");
        }
    }
}
