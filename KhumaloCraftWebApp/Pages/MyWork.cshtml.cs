using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace KhumaloCraftWebApp.Pages
{
    public class MyWorkModel : PageModel
    {
        public List<Craftwork> Craftworks { get; set; }

        public void OnGet()
        {
            // Initialize the Craftworks with static data
            Craftworks = new List<Craftwork>
            {
                new Craftwork { Name = "Organic Necklace", Description = "Beautiful handmade necklace made from organic materials.", Price = 25.99, ImageUrl = "/images/organic necklace.jpeg" },
                new Craftwork { Name = "Handwoven Basket", Description = "Elegant handwoven basket, perfect for home decor.", Price = 19.99, ImageUrl = "/images/handwoven basket.jpeg" },
                new Craftwork { Name = "Zulu Bracelet", Description = "Intricate Zulu bracelet.", Price = 39.99, ImageUrl = "/images/zulu bracelet.jpeg" }
            };
        }
    }

    public class Craftwork
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
