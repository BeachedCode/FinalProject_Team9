using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    public class BreakfastfoodController : Controller
    {
        [ApiController]
        [Route("[controller]")]

        IBreakfastfood ctx;
        public BreakfastfoodController(IBreakfastfood breakfastfoods)
        {
            ctx = breakfastfoods;
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
        public IActionResult Post(BreakfastFood food)
        {
            ctx.AddBreakfastFood(food);
            return Ok();
        }
    }
}
