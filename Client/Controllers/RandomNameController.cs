using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomNameController: ControllerBase
    {

        private readonly HttpClient _fName;
        private readonly HttpClient _lName;

        public RandomNameController(IHttpClientFactory factory)
        {
            _fName = factory.CreateClient("FName");
            _lName = factory.CreateClient("LName");
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            string name = await _fName.GetStringAsync("api/FName") + " " + await _lName.GetStringAsync("api/LName");
            return Ok(name);
        }
    }
}
