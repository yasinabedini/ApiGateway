using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProductService.Models;
using System.IO.Pipelines;
using System.Text.Json.Serialization;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Database.json");
            using (StreamReader reader = new StreamReader(path))
            {
                string productsString = reader.ReadToEnd();
                return Ok(JsonConvert.DeserializeObject<List<Product>>(productsString));
            }
        }
    }
}
