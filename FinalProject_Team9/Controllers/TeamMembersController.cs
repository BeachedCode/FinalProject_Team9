using FinalProject_Team9.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    public class TeamMembersController : Controller
    {

        ITeamMember ctx;
        public TeamMembersController(ITeamMember teamMember)
        {
            ctx = teamMember;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(ctx.GetTeamMembers());
        }

        [HttpGet("id")]
        public IActionResult Get(int id) //Read
        {
            return Ok(ctx.GetTeamMembersById(id));
        }

        [HttpPost]
        public IActionResult Post(TeamMembers team) //Create
        {
            ctx.AddTeamMember(team);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(TeamMembers team) //Update
        {
            var result = ctx.UpdateTeamMembers(team);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");                
            }
            return Ok();
        }

        [HttpDelete("id")]
        [Route("api/delete")]
        public IActionResult Delete(int id)
        {
            var team = ctx.GetTeamMembersById(id);
            if(team == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveTeamMemberById(id);
            if(result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
}
