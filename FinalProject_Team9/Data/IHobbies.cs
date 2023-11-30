using FinalProject_Team9.Models;

namespace FinalProject_Team9.Data
{
    public interface IHobbies
    {
        int? AddHobbies(Hobbies hobbies);
        List<Hobbies> GetHobbies();
        Hobbies GetHobbiesById(int id);
    }
}
