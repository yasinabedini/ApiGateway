using CommentService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CommentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Database.json");
            using (StreamReader reader = new StreamReader(path))
            {
                string productsString = reader.ReadToEnd();
                return Ok(JsonConvert.DeserializeObject<List<Comment>>(productsString));
            }
        }
    }
}
