using Client.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Client.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly HttpClient _productService;        

        public List<ProductViewModel> Products { get; set; }

        public IndexModel(IHttpClientFactory factory)
        {
            _productService = factory.CreateClient("ProductService");            

        }
        public async void OnGet()
        {
            var productList = await _productService.GetStringAsync("api/produc");
            Products = JsonConvert.DeserializeObject<List<ProductViewModel>>(productList);
        }
    }
}
