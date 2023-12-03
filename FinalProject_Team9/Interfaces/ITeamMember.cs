namespace FinalProject_Team9.Data.Interfaces
{
    public interface ITeamMember
    {
        int? AddTeamMember(TeamMembers teamMembers);
        List<TeamMembers> GetTeamMembers();
        TeamMembers GetTeamMembersById(int id);
        int? UpdateTeamMembers(TeamMembers teamMembers);
        int? RemoveTeamMembersById(int id);
    }
}
