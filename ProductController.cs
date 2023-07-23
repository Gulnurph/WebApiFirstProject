using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly string[] products =
        {
            "Samsun a1","galaxy s3"
        };
        [HttpGet]
        public string[] GetProducts()
        {
            return products;
        }
        [HttpGet("{id}")]//iki GET METTOT AYIRT ETMEK İÇİN ID BİLGİSİNİ VER
        public string GetProduct(int id)
        {
            return products[id];
        }
    }
}
