using FinalProject_Team9.Models;

namespace FinalProject_Team9.Data.Interfaces
{
    public interface ICities
    {
        int? AddCities(Cities cities);
        List<Cities> GetCities();
        object GetCitiesById(int id);
        Cities GetCityById(int id);
        int? RemoveCitiesById(int id);
        int? UpdateCites(Cities cities);
    }
}

