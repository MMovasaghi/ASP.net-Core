using Microsoft.AspNetCore.Mvc;
using WebApplication004.Models;

namespace WebApplication004.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View(SimpleRepository.SharedRepository.Products);
    }
}
