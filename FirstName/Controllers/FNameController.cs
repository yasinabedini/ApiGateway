using Microsoft.AspNetCore.Mvc;

namespace FirstName.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FNameController : ControllerBase
    {
        private List<string> fNames => new List<string>
        {
            "yasin",
            "ali",
            "hossein",
            "ramin",
            "mohammad"
        };

        private Random random = new Random();

        [HttpGet]        
        public IActionResult Get()
        {
            int index = random.Next(0, fNames.Count-1);

            return Ok(fNames[index]);
        }
    }
}
