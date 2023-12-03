using FinalProject_Team9.Models;

namespace FinalProject_Team9.Data.Interfaces
{
    public interface IBreakfast
    {
        int? AddBreakfastFood(Breakfastfood breakfastfood);
        List<Breakfastfood> GetAllBreakfastFoods();
        Breakfastfood GetBreakfastFoodsById(int id);
        int? RemoveBreakfastFoodsById(int id);
        int? UpdateBreakfastFood(Breakfastfood breakfastfood);
    }
}
