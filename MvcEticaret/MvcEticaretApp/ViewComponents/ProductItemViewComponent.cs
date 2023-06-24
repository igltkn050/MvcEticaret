using Microsoft.AspNetCore.Mvc;
using MvcEticaretApp.Models;

public class ProductViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(string title, int starCount, decimal oldPrice, decimal price, string imageUrl, bool isSale, int id)
    {
        var product = new Product()
        {
            Title = title,
            StarCount = starCount,
            OldPrice = oldPrice,
            Price = price,
            ImageUrl = imageUrl,
            IsSale = isSale,
            Id = id
        };

        return View(product);
    }
}  