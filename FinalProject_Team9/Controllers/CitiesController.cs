using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    public class CitiesController : Controller
    {
        [ApiController]
        [Route("[controller]")]

        TeamContext ctx;
        public CitiesController(TeamContext cities)
        {
            ctx = cities;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(ctx.GetAllItems());
        }

        [HttpPost]
        public IActionResult Post(Towns p)
        {
            ctx.AddItem(p);
            return Ok();
        }
    }
}
