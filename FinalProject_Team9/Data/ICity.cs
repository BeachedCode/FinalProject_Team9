using FinalProject_Team9.Models;

namespace FinalProject_Team9.Data
{
    public interface ICity
    {
        int? AddCity(ICity city);
        List<Cities> GetCities();
        Cities GetCityById(int id);
    }
}
