namespace FinalProject_Team9.Data
{
    public interface ITeamMember
    {
        int? AddTeamMember(TeamMembers teamMembers);
        List<TeamMembers> GetTeamMembers();
        TeamMembers GetTeamMembersById(int id);
        int? UpdateTeamMembers(TeamMembers teamMembers);
        int? RemoveTeamMemberById(int id);
    }
}
