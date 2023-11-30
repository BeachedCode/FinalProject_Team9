using FinalProject_Team9.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Team9.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class TeamMembersController : Controller
    {

        ITeamMember ctx;
        public TeamMembersController(ITeamMember teammembers)
        {
            ctx = teammembers;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(ctx.GetTeamMembers());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetTeamMembersById(id));
        }

        [HttpPost]
        public IActionResult Post(TeamMembers team)
        {
            ctx.AddTeamMember(team);
            return Ok();
        }
    }
}
