using System;

class Marketplace
{
    static void Main(string[] args)
    {
        DiscountService discountService = new DiscountService();

        Console.WriteLine("Enter number of products:");
        int n = Convert.ToInt32(Console.ReadLine());

        ProductBase[] catalog = new ProductBase[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nSelect Category:");
            Console.WriteLine("1. Book");
            Console.WriteLine("2. Clothing");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter product name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter product price:");
            double price = Convert.ToDouble(Console.ReadLine());

            if (choice == 1)
            {
                catalog[i] = new Product<BookCategory>(
                    name,
                    price,
                    new BookCategory()
                );
            }
            else if (choice == 2)
            {
                catalog[i] = new Product<ClothingCategory>(
                    name,
                    price,
                    new ClothingCategory()
                );
            }
        }

        Console.WriteLine("\nEnter discount percentage:");
        double percent = Convert.ToDouble(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            discountService.ApplyDiscount(catalog[i], percent);
        }

        Console.WriteLine("\n--- Product Catalog ---");
        for (int i = 0; i < n; i++)
        {
            catalog[i].Display();
        }
    }
}
