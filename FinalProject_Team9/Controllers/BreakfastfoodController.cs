using FinalProject_Team9.Data;
using FinalProject_Team9.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
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
            return Ok(ctx.GetsBreakfastFoodsById(id));
        }

        [HttpPost]
        public IActionResult Post(Breakfastfood breakfastfood)
        {
            ctx.AddBreakfastFood(breakfastfood);
            return Ok();
        }
    }
}
