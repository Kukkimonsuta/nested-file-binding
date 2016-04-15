using Microsoft.AspNetCore.Mvc;
using HelloMvc.Models;

namespace HelloMvc
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index() => View();
        
        [HttpPost("/")]
        public IActionResult Index(HomeIndexModel model)
        {
            return View(model);
        }
    }
}