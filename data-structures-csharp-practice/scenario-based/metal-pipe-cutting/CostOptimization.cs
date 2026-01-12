using System;

class CostOptimization
{
    static void Main()
    {
        int rodLength = 8; //UC1: Given rod length 8

        int[] prices = { 0, 2, 5, 7, 3, 9, 11, 14, 16 };

        //Create Rod object
        Rod rod = new Rod(rodLength, prices);

        //Create service object
        RodCutting cuttingService = new RodCutting();

        //UC1: Optimized revenue using DP
        int maxRevenue = cuttingService.CalculateMaxRevenue(rod);
        Console.WriteLine("Rod Length: " + rodLength);
        Console.WriteLine("Maximum revenue using optimized cutting: " + maxRevenue);

        //UC2: Custom rod length
        Console.WriteLine("\nEnter custom rod length:");
        int customLength = Convert.ToInt32(Console.ReadLine());

        Rod rodB = new Rod(customLength, prices);
        int revenueB = cuttingService.CalculateMaxRevenue(rodB);

        Console.WriteLine("CustomRod Length: " + customLength);
        Console.WriteLine("Maximum revenue: " + revenueB);

        //UC3: Calculating non opitimize revenue to show difference
        int nonOptimizedRevenue = prices[8];

        Console.WriteLine("Rod Length: 8");
        Console.WriteLine("Non-Optimized Revenue : " + nonOptimizedRevenue);

        Console.WriteLine("\nLoss due to no optimization:");
        Console.WriteLine(maxRevenue - nonOptimizedRevenue);




    }
}
