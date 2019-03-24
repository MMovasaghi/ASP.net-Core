using Microsoft.AspNetCore.Mvc;
using WebApplication004.Models;
using System.Linq;

namespace WebApplication004.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View(SimpleRepository.SharedRepository.Products.Where(p => p.Price < 40));
    }
}
