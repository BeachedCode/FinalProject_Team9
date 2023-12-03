using FinalProject_Team9.Data.Interfaces;
using FinalProject_Team9.Models;

namespace FinalProject_Team9.Data
{
    public class TeamMemberService : ITeamMember
    {
        TeamContext ctx;
        
        public TeamMemberService(TeamContext context)
        {
            ctx = context;
        }

        List<TeamMembers> ITeamMember.GetTeamMembers()
        {
            return ctx.Member.ToList();
        }

        public TeamMembers GetTeamMembersById(int id)
        {
            return ctx.Member.FirstOrDefault(x => x.Id == id);
        }

        public int? AddTeamMember(TeamMembers t)
        {         
            var members = this.GetTeamMembersById(t.Id);
            if (members != null) 
            {
                return null;
            }
            ctx.Member.Add(t);
            return ctx.SaveChanges();
        }
        
        public int? RemoveTeamMembersById(int id)
        {
            var member = this.GetTeamMembersById(id);
            if (member == null) 
                {
                    return null;
                }
            ctx.Member.Remove(member);
            return ctx.SaveChanges();
        }

        public int? UpdateTeamMembers(TeamMembers team)
        {
            ctx.Member.Update(team);
            return ctx.SaveChanges();
        }
    
    }
}
