using FinalProject_Team9.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamMembersController : Controller
    {
        private readonly ITeamMember ctx;

        public TeamMembersController(ITeamMember teammembers)
        {
            ctx = teammembers;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ctx.GetTeamMembers());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id) // Read
        {
            return Ok(ctx.GetTeamMembersById(id));
        }

        [HttpPost]
        public IActionResult Post(TeamMembers team) // Create
        {
            ctx.AddTeamMember(team);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(TeamMembers team) // Update
        {
            var result = ctx.UpdateTeamMembers(team);
            if (result == 0)
            {
                return StatusCode(500, "An error occurred while processing your request");
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        [Route("api/delete")]
        public IActionResult Delete(int id) // Delete
        {
            var team = ctx.GetTeamMembersById(id);
            if (team == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveTeamMembersById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occurred while processing your request");
            }
            return Ok();
        }
    }
}


