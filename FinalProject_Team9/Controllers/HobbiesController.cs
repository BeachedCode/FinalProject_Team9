using FinalProject_Team9.Data.Interfaces;
using FinalProject_Team9.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    [ApiController]
    [Route("[controller]")]

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
        public IActionResult Post(Hobbies hobbies) //Create
        {
            ctx.AddHobbies(hobbies);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Hobbies hobbies) //Update
        {
            var result = ctx.UpdateHobbies(hobbies);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete("id")]
        [Route("api/delete")]
        public IActionResult Delete(int id) //Delete
        {
            var hobbies = ctx.GetHobbiesById(id);
            if (hobbies == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveHobbiesById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
}
