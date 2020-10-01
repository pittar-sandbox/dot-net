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
            
            Product p1 = new Product();
            p1.description = "1TB SSD M2 - Geforce RTX";
            p1.name = "Lenovo i7 32GB RAM";
            p1.price = 2399.99;

            Product p2 = new Product();
            p2.description = "1TB SSD - Geforce 4GB - Magic mouse inclus.";
            p2.name = "Macbook pro 16 pouces 32GB RAM";
            p2.price = 4599.99;

            Product p3 = new Product();
            p3.description = "512GB SSD - Intel Graphics";
            p3.name = "Acer i5 8GB RAM";
            p3.price = 899.99;
            
            return new List<Product> {p1, p2};


            //using (var httpClient = new HttpClient())
            //{
            //    using (var response = await httpClient.GetAsync("https://i-get-product-list-fuse.apps.ocp.myocp.net/api/product"))
            //    {
            //        string apiResponse = await response.Content.ReadAsStringAsync();
            //        return JsonSerializer.Deserialize<List<Product>>(apiResponse);
            //    }
            //}
        }
    }
}
