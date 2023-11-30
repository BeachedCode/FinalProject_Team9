using FinalProject_Team9.Data;
using FinalProject_Team9.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    public class HobbiesController : Controller
    {

        IHobbies ctx;
        public HobbiesController(IHobbies hobbies)
        {
            ctx = hobbies;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(ctx.GetHobbies());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetHobbiesById(id));
        }

        [HttpPost]
        public IActionResult Post(Hobbies hobbies)
        {
            ctx.AddHobbies(hobbies);
            return Ok();
        }
    }
}
