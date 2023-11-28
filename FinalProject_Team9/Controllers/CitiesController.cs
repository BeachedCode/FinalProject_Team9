using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    public class CitiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
