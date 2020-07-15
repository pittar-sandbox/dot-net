using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace simpleproject_products_api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            List<Product> productList = new List<Product>();

            _logger.LogInformation("DOTNETCORE-PRODUCTS-API: Get Product List");

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://i-product-api-fuse-online.apps.mgmt.myocp.net/api/product"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<List<Product>>(apiResponse);
                }
            }
        }
    }
}
