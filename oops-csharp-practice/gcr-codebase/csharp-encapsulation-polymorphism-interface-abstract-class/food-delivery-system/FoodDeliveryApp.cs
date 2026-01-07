using System;

class FoodDeliveryApp
{
    static void Main()
    {
        FoodItem[] foodItemList = new FoodItem[2];

        Console.WriteLine("Enter Veg Item Details");
        Console.WriteLine("Item Name: ");
        string vegItemName = Console.ReadLine();
        Console.WriteLine("Price: ");
        double vegItemPrice = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Quantity: ");
        int vegItemQuantity = Convert.ToInt32(Console.ReadLine());

        VegItem vegFoodItem = new VegItem(vegItemPrice, vegItemQuantity);
        vegFoodItem.ItemName = vegItemName;

        foodItemList[0] = vegFoodItem;

        Console.WriteLine("\nEnter Non-Veg Item Details");
        Console.WriteLine("Item Name: ");
        string nonVegItemName = Console.ReadLine();
        Console.WriteLine("Price: ");
        double nonVegItemPrice = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Quantity: ");
        int nonVegItemQuantity = Convert.ToInt32(Console.ReadLine());

        NonVegItem nonVegFoodItem =
            new NonVegItem(nonVegItemPrice, nonVegItemQuantity);

        nonVegFoodItem.ItemName = nonVegItemName;

        foodItemList[1] = nonVegFoodItem;

        Console.WriteLine("\nFood Order Details");

        for (int index = 0; index < foodItemList.Length; index++)
        {
            double discountAmount = 0;

            //check if item is discountable
            if (foodItemList[index] is IDiscountable)
            {
                IDiscountable discountableItem =
                    (IDiscountable)foodItemList[index];

                discountAmount = discountableItem.ApplyDiscount();
                Console.WriteLine(discountableItem.GetDiscountDetails());
            }

            double finalAmount =
                foodItemList[index].CalculateTotalPrice() - discountAmount;

            Console.WriteLine("Item Name: " + foodItemList[index].ItemName);
            Console.WriteLine("Final Amount: " + finalAmount);
            Console.WriteLine();
        }
    }
}
