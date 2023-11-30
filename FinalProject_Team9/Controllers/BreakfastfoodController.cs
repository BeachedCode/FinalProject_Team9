using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    public class BreakfastfoodController : Controller
    {
        [ApiController]
        [Route("[controller]")]

        TeamContext ctx;
        public BreakfastfoodController(TeamContext breakfastfood)
        {
            ctx = breakfastfood;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(ctx.GetAllItems());
        }

        [HttpPost]
        public IActionResult Post(Foods p)
        {
            ctx.AddItem(p);
            return Ok();
        }
    }
}
