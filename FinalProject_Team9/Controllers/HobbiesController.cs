using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    public class HobbiesController : Controller
    {
        [ApiController]
        [Route("[controller]")]

        TeamContext ctx;
        public HobbiesController(TeamContext hobbies)
        {
            ctx = hobbies;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(ctx.GetAllItems());
        }

        [HttpPost]
        public IActionResult Post(Things p)
        {
            ctx.AddItem(p);
            return Ok();
        }
    }
}
