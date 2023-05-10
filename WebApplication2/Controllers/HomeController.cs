using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
   
    public class HomeController : Controller
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
            return View(products);
        }
        public IActionResult Contact()
        {

            ViewBag.About = "haqqinda";
            ViewBag.Phone = "0519289812";
            ViewBag.Adresses = "bulbul pr.60";
            ViewBag.Location = "Location";
            return View();
        }

        
    }
}
