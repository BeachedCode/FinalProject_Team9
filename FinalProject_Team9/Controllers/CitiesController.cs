using FinalProject_Team9.Data.Interfaces;
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
        public IActionResult Post(Cities cities) //Create
        {
            ctx.AddCities(cities);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Cities cities) //Update
        {
            var result = ctx.UpdateCites(cities);
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
            var cities = ctx.GetCitiesById(id);
            if (cities == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveCitiesById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
}
