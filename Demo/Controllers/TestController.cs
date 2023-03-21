using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Greet()
        {
            return Ok(new { Name="Surendar",Character="God level good boy",Beauty="Always handsome"});
        }
    }
}
