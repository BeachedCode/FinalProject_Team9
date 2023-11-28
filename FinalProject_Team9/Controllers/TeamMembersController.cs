using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    public class TeamMembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
