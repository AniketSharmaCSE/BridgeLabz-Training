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

        Console.WriteLine("Wood Length: " + woodLength);
        Console.WriteLine("Maximum Revenue: " + maxRevenue);

        //UC2: maximum earning when customer adds a fixed waste constraint
        Console.WriteLine("Enter maximum allowed waste (in ft):");
        int maxAllowedWaste = Convert.ToInt32(Console.ReadLine());

        int revenueWithConstraint =
            service.CalculateRevenueWithWasteConstraint(woodLength,maxAllowedWaste,prices);

        Console.WriteLine("Maximum Allowed Waste: " + maxAllowedWaste + " ft");
        Console.WriteLine("Maximum Revenue: " + revenueWithConstraint);

        //UC3: Best revenue with minimal waste
        int waste;

        int bestRevenueUC3 = service.CalculateBestRevenueWithMinimumWaste(woodLength, prices, out waste);

        Console.WriteLine("Best Revenue: " + bestRevenueUC3);
        Console.WriteLine("Waste: " + waste + " ft");



    }
}
