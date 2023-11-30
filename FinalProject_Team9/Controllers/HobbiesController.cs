using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    public class HobbiesController : Controller
    {
        [ApiController]
        [Route("[controller]")]

        IItemService ctx;
        public ItemController(IItemService service)
        {
            ctx = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(ctx.GetAllItems());
        }

        [HttpPost]
        public IActionResult Post(Item p)
        {
            ctx.AddItem(p);
            return Ok();
        }
    }
}
