using System;

class FurnitureOptimization
{
    static void Main()
    {
        //UC1: Maximum earning for wood length 12
        int woodLength = 12;

        int[] prices = { 0, 2, 5, 7, 9, 10, 17, 17, 20, 24, 30, 31, 34 };

        Wood wood = new Wood(woodLength, prices);
        WoodCuttingService service = new WoodCuttingService();

        int maxRevenue = service.CalculateMaxRevenue(wood);

        Console.WriteLine("Context A: Custom Furniture Manufacturing");
        Console.WriteLine("Wood Length: " + woodLength);
        Console.WriteLine("Maximum Revenue: " + maxRevenue);
    }
}
