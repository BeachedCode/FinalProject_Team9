using FinalProject_Team9.Models;

namespace FinalProject_Team9.Data
{
    public interface IBreakfast
    {
        int? AddBreakfastFood(Breakfastfood breakfastfood);
        List<Breakfastfood> GetAllBreakfastFoods();
        Breakfastfood GetsBreakfastFoodsById(int id);
    }
}
