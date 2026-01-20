using System;

class MealPlan
{
    static void Main(string[] args)
    {
        MealService service = new MealService();
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\n--- Meal Plan Generator ---");
            Console.WriteLine("1. Vegetarian");
            Console.WriteLine("2. Vegan");
            Console.WriteLine("3. Keto");
            Console.WriteLine("4. High Protein");
            Console.WriteLine("5. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    service.GenerateMeal(new VegetarianMeal());
                    break;

                case 2:
                    service.GenerateMeal(new VeganMeal());
                    break;

                case 3:
                    service.GenerateMeal(new KetoMeal());
                    break;

                case 4:
                    service.GenerateMeal(new HighProteinMeal());
                    break;

                case 5:
                    Console.WriteLine("Exiting Meal Generator");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
