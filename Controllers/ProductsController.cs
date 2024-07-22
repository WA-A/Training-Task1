using Microsoft.AspNetCore.Mvc;
using Task1.Models;

namespace Task1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = GetProducts();
            return View(products);
        }

        private List<Products> GetProducts()
        {
            // Sample product data
            return new List<Products>
            {
                new Products { ImageUrl = "Images/Screenshot 2024-07-22 150612.png", Name = "LEVN Headset with Mic", Price = 25.99 },
                new Products { ImageUrl = "Images/Screenshot 2024-07-22 150618.png", Name = "Crayola Crayon Tub", Price = 25.50 },
                new Products { ImageUrl = "Images/Screenshot 2024-07-22 150624.png", Name = "Crayola Bulk Colored Pencils", Price = 44.99 },
                new Products { ImageUrl = "Images/Screenshot 2024-07-22 150633.png", Name = "EKSA E1000 USB Gaming Headset", Price = 24.99 },
                new Products { ImageUrl = "Images/Screenshot 2024-07-22 150638.png", Name = "Crayola Colored Pencils Classpack", Price = 47.09 },
                new Products { ImageUrl = "Images/Screenshot 2024-07-22 150647.png", Name = "Dare to Lead: Brave Work", Price = 12.99 },
                ///////////////////////
        new Products { ImageUrl = "Images/Screenshot 2024-07-22 155445.png", Name = "Electric Clipper", Price = 39.99, DiscountPrice = 38m, Description = "Electric Clipper with Attachments" },
        new Products { ImageUrl = "Images/Screenshot 2024-07-22 160031.png", Name = "Men's Clipper", Price = 49.99, DiscountPrice = 70m, Description = "Rechargeable Men's Clipper" },
        new Products { ImageUrl = "Images/Screenshot 2024-07-22 160056.png", Name = "Casual Shoes", Price = 32.99, DiscountPrice = 58m, Description = "Casual Sneakers - Black" },
        new Products { ImageUrl = "Images/Screenshot 2024-07-22 160050.png", Name = "Skechers Men's GOWalk", Price = 119.99, DiscountPrice = 230m, Description = "Skechers Otis Shoes" },
        new Products { ImageUrl = "Images/Screenshot 2024-07-22 160043.png", Name = "Skechers Sneakers", Price = 222, DiscountPrice = 350m, Description = "Skechers Sports Sneakers" },
        new Products { ImageUrl = "Images/Screenshot 2024-07-22 160038.png", Name = "Air Stand Sneakers", Price = 299.99, DiscountPrice = 350m, Description = "Comfortable Air Stand Sneakers" },
        new Products { ImageUrl = "Images/Screenshot 2024-07-22 160109.png", Name = "Men's Joggers", Price = 169.99, DiscountPrice = 278m, Description = "Under Armour Men's Joggers" },
        new Products { ImageUrl = "Images/Screenshot 2024-07-22 160103.png", Name = "UA Tech T-Shirt", Price = 139.99, DiscountPrice = 230m, Description = "Under Armour Men's UA Tech T-Shirt" }
            };
        }
    }
}
