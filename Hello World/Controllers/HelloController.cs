using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hello_World.Controllers
{
    [Route("hello/api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet("SayHello")]
        public async Task<IActionResult> SayHello()
        {
            return Ok("Hello");
        }
    }
}