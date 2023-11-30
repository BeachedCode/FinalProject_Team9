using FinalProject_Team9.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    public class CitiesController : Controller
    {

        ICity ctx;
        public CitiesController(Icity cities)
        {
            ctx = cities;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(ctx.GetAllCities());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetCitiesById(id));
        }

        [HttpPost]
        public IActionResult Post(City town)
        {
            ctx.AddCity(town);
            return Ok();
        }
    }
}
