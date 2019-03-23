using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication003.Models;

namespace WebApplication003.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Product[] arr =
            {
                new Product { Name = "Kayak", Price = 100M},
                new Product { Name = "Lifejacket", Price = 200M},
                new Product { Name = "Soccer Ball", Price = 90M},
                new Product { Name = "Corner Ball", Price = 200M},
            };
            return View(arr);
        }
    }
}
