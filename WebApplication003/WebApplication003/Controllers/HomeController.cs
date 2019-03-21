﻿using System;
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
            Product myProduct = new Product
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "A boat for one person",
                Category = "Watersports",
                Price = 275M
            };
            return View(myProduct);
        }
    }
}
