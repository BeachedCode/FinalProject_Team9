using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    public class HobbiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
