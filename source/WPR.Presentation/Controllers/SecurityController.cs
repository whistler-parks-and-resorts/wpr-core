using Microsoft.AspNetCore.Mvc;

namespace WPR.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SecurityController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateUser()
        {
            return Ok();
        }
    }
}
