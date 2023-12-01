using FinalProject_Team9.Data;
using FinalProject_Team9.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CitiesController : Controller
    {

        ICities ctx;
        public CitiesController(ICities cities)
        {
            ctx = cities;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(ctx.GetCities());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetCityById(id));
        }

        [HttpPost]
        public IActionResult Post(Cities cities)
        {
            ctx.AddCities(cities);
            return Ok();
        }
    }
}
