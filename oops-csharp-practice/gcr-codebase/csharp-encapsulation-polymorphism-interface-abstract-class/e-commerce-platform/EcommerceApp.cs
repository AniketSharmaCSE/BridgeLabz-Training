using System;

class EcommerceApp
{
    static void Main()
    {
        Product[] productList = new Product[3];

        Console.WriteLine("Enter Electronics Details");
        Console.WriteLine("Product Id: ");
        int electronicsProductId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Product Name: ");
        string electronicsProductName = Console.ReadLine();
        Console.WriteLine("Price: ");
        double electronicsPrice = Convert.ToDouble(Console.ReadLine());

        Electronics electronicsProduct = new Electronics(electronicsPrice);
        electronicsProduct.ProductId = electronicsProductId;
        electronicsProduct.ProductName = electronicsProductName;

        productList[0] = electronicsProduct;

        Console.WriteLine("\nEnter Clothing Details");
        Console.WriteLine("Product Id: ");
        int clothingProductId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Product Name: ");
        string clothingProductName = Console.ReadLine();
        Console.WriteLine("Price: ");
        double clothingPrice = Convert.ToDouble(Console.ReadLine());

        Clothing clothingProduct = new Clothing(clothingPrice);
        clothingProduct.ProductId = clothingProductId;
        clothingProduct.ProductName = clothingProductName;

        productList[1] = clothingProduct;

        Console.WriteLine("\nEnter Groceries Details");
        Console.WriteLine("Product Id: ");
        int groceryProductId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Product Name: ");
        string groceryProductName = Console.ReadLine();
        Console.WriteLine("Price: ");
        double groceryPrice = Convert.ToDouble(Console.ReadLine());


        Groceries groceryProduct = new Groceries(groceryPrice);
        groceryProduct.ProductId = groceryProductId;
        groceryProduct.ProductName = groceryProductName;

        productList[2] = groceryProduct;

        Console.WriteLine("\nFinal Price Details");

        for (int index = 0; index < productList.Length; index++)
        {
            double taxAmount = 0;

            //check if product is taxable
            if (productList[index] is ITaxable)
            {
                ITaxable taxableProduct = (ITaxable)productList[index];
                taxAmount = taxableProduct.CalculateTax();
            }

            double discountAmount = productList[index].CalculateDiscount();

            double finalPrice = 
                (productList[index] is Product ? ((dynamic)productList[index]).price : 0) + taxAmount - discountAmount;

            Console.WriteLine("Product Name: " + productList[index].ProductName);
            Console.WriteLine("Final Price: " + finalPrice);
            Console.WriteLine();
        }
    }
}
