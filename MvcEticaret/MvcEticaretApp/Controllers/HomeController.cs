using Microsoft.AspNetCore.Mvc;
using MvcEticaretApp.Models;
using System.Diagnostics;

namespace MvcEticaretApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() 
        {
            var products = new List<Product>();

            products.Add(new Product() { Title = "Ürün1", Id = 1 , StarCount = 1 , Price = 10 , OldPrice = 20 , IsSale = true , ImageUrl = "https://img.memurlar.net/galeri/15122/9eeb47af-e6a7-e811-80dc-a0369f7d1486.jpg?width=800" });
            products.Add(new Product() { Title = "Ürün2", Id = 2, StarCount = 2, Price = 20, OldPrice = 30, IsSale = false, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRwu3BS-R1ZuJ1uGiQmAg5WYh4q5ox8SECPBQ&usqp=CAU" });
            products.Add(new Product() { Title = "Ürün3", Id = 3, StarCount = 3, Price = 30, OldPrice = 40, IsSale = true, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ5PIu7EwlcVFMStCEUQ6K0oe0Yk8ajCTMvXA&usqp=CAU" });
            products.Add(new Product() { Title = "Ürün4", Id = 4, StarCount = 2, Price = 40, OldPrice = 50, IsSale = false, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ5PIu7EwlcVFMStCEUQ6K0oe0Yk8ajCTMvXA&usqp=CAU" });
            products.Add(new Product() { Title = "Ürün5", Id = 5, StarCount = 2, Price = 50, OldPrice = 60, IsSale = true, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ5PIu7EwlcVFMStCEUQ6K0oe0Yk8ajCTMvXA&usqp=CAU" });
            products.Add(new Product() { Title = "Ürün6", Id = 6, StarCount = 4, Price = 60, OldPrice = 70, IsSale = false, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ5PIu7EwlcVFMStCEUQ6K0oe0Yk8ajCTMvXA&usqp=CAU" });
            products.Add(new Product() { Title = "Ürün7", Id = 7, StarCount = 1, Price = 70, OldPrice = 80, IsSale = true, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ5PIu7EwlcVFMStCEUQ6K0oe0Yk8ajCTMvXA&usqp=CAU" });
            products.Add(new Product() { Title = "Ürün8", Id = 8, StarCount = 5, Price = 80, OldPrice = 90, IsSale = false, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ5PIu7EwlcVFMStCEUQ6K0oe0Yk8ajCTMvXA&usqp=CAU" });

            return View(products);
        }
    }
}