using FinalProject_Team9.Models;

namespace FinalProject_Team9.Data.Interfaces
{
    public interface IHobbies
    {
        int? AddHobbies(Hobbies hobbies);
        List<Hobbies> GetHobbies();
        Hobbies GetHobbiesById(int id);
        int? RemoveHobbiesById(int id);
        int? UpdateHobbies(Hobbies hobbies);
    }
}
