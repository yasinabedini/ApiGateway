using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LastName.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LNameController : ControllerBase
    {
        private List<string> lNames => new List<string>
        {
            "abedini",
            "momeni",
            "sadati",
            "ghiasi",
            "hosseini"
        };

        private Random random = new Random();

        [HttpGet]
        public IActionResult Get()
        {
            int index = random.Next(0, lNames.Count - 1);

            return Ok(lNames[index]);
        }
    }
}
