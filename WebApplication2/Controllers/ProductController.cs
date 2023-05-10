using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class ProductController:Controller
    {
        public List<Product> products = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name= "saat",
                Price=240,
                ReleaseDate="10/05",
                ProductCount=5,
            },
            new Product
            {
                Id = 2,
                Name= "telefon",
                Price=2240,
                ReleaseDate="10/05",
                ProductCount=5,
            },
            new Product
            {
                Id = 3,
                Name= "qolbaq",
                Price=40,
                ReleaseDate="10/05",
                ProductCount=7,
            },
            new Product
            {
                Id = 4,
                Name= "saat",
                Price=100,
                ReleaseDate="10/05",
                ProductCount=10,
            },
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            Product product = products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }
    }
}
