using FinalProject_Team9.Data;
using FinalProject_Team9.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class BreakfastfoodController : Controller
    {

        IBreakfast ctx;
        public BreakfastfoodController(IBreakfast breakfastfood)
        {
            ctx = breakfastfood;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(ctx.GetAllBreakfastFoods());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetBreakfastFoodsById(id));
        }

        [HttpPost]
        public IActionResult Post(Breakfastfood breakfastfood) //Create
        {
            ctx.AddBreakfastFood(breakfastfood);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Breakfastfood breakfastfood) //Update
        {
            var result = ctx.UpdateBreakfastFood(breakfastfood);
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
            var breakfastfood = ctx.GetBreakfastFoodsById(id);
            if (breakfastfood == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveBreakfastFoodsById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
}
