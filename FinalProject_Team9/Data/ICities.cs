using FinalProject_Team9.Models;

namespace FinalProject_Team9.Data
{
    public interface ICities
    {
        int? AddCities(Cities cities);
        List<Cities> GetCities();
        Cities GetCityById(int id);
    }
}

