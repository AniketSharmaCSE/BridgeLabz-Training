public class MealService
{
    public void GenerateMeal<T>(T meal) where T : IMealPlan
    {
        Meal<T> mealObj = new Meal<T>(meal);
        mealObj.DisplayMeal();
    }
}
