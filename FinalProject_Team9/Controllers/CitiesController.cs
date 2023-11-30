using FinalProject_Team9.Data;
using FinalProject_Team9.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    public class CitiesController : Controller
    {
        ICity ctx;
        public CitiesController (ICity city)
        {
            ctx = city;
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
        public IActionResult Post(Cities c)
        {
            ctx.AddCity(c);
            return Ok();
        }
    }
}
