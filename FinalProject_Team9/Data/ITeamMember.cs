namespace FinalProject_Team9.Data
{
    public interface ITeamMember
    {
        int? AddTeamMember(TeamMembers teamMembers);
        List<TeamMembers> GetTeamMembers();
        TeamMembers GetTeamMembersById(int id);
    }
}
