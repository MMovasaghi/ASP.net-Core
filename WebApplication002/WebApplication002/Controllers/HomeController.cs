using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication002.Models;

namespace WebApplication002.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ViewResult> Index()
        {
            //long? length = await MyAsyncMethods.GetPageLength2();
            //if(length != null)
            //    return View(new string[] { $"Length: {length}" });
            //else
            //    return View(new string[] { $"Length: Hello" });
            var products = new[] {
                 new { Name = "Kayak", Price = 275M },
                 new { Name = "Lifejacket", Price = 48.95M },
                 new { Name = "Soccer ball", Price = 19.50M },
                 new { Name = "Corner flag", Price = 34.95M }
             };
            return View(products.Select(p =>  $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }
    }
}
