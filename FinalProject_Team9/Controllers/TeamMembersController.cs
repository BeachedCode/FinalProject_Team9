using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    public class TeamMembersController : Controller
    {
        [ApiController]
        [Route("[controller]")]

        TeamContext ctx;
        public TeamMembersController(TeamContext teammembers)
        {
            ctx = teammembers;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(ctx.GetAllItems());
        }

        [HttpPost]
        public IActionResult Post(Members p)
        {
            ctx.AddItem(p);
            return Ok();
        }
    }
}
