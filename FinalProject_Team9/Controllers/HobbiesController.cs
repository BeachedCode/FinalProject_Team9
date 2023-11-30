using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    public class HobbiesController : Controller
    {
        [ApiController]
        [Route("[controller]")]

        IHobby ctx;
        public HobbiesController(IHobby hobbies)
        {
            ctx = hobbies;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(ctx.GetAllHobbies());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetHobbiesById(id));
        }

        [HttpPost]
        public IActionResult Post(Hobby thing)
        {
            ctx.AddHobby(thing);
            return Ok();
        }
    }
}
