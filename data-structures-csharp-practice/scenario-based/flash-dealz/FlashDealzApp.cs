using System;

class FlashDealzApp
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of products: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Product[] products = new Product[n];
        DiscountService discountService = new DiscountService();
        ProductSortService sortService = new ProductSortService();

        int count = 0;
        int choice;

        do
        {
            Console.WriteLine("\n--- FlashDealz Menu ---");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Sort Products by Discount");
            Console.WriteLine("3. Display Products");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                if (count >= n)
                {
                    Console.WriteLine("Product limit reached.");
                }
                else
                {
                    Console.Write("Enter product name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter product price: ");
                    double price = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter discount percentage: ");
                    double percentage = Convert.ToDouble(Console.ReadLine());

                    Product product = new Product(name, price);
                    discountService.CalculateAndApplyDiscount(product, percentage);

                    products[count] = product;
                    count++;

                    Console.WriteLine("Product added successfully.");
                }
            }
            else if (choice == 2)
            {
                if (count > 1)
                {
                    sortService.QuickSort(products, 0, count - 1);
                }

                Console.WriteLine("\n--- Sorted Products ---");
                DisplayProducts(products, count);
            }
            else if (choice == 3)
            {
                DisplayProducts(products, count);
            }

        } while (choice != 0);

        Console.WriteLine("Exiting FlashDealz...");
    }

    static void DisplayProducts(Product[] products, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(
                products[i].GetName() +
                " | Original Price: " + products[i].GetPrice() +
                " | Discount: " + products[i].GetDiscountPercent() + "%" +
                " | Final Price: " + products[i].GetDiscountedPrice()
            );
        }
    }
}
