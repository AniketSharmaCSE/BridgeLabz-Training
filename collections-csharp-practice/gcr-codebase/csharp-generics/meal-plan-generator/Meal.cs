public class Meal<T> where T : IMealPlan
{
    private T mealPlan;

    public Meal(T meal)
    {
        mealPlan = meal;
    }

    public void DisplayMeal()
    {
        mealPlan.ShowMeal();
    }
}
