using System;

class CostOptimization
{
    static void Main()
    {
        int rodLength = 8; //UC1: Given rod length 8

        int[] prices = { 0, 1, 4, 7, 3, 10, 10, 15, 20 };

        //Create Rod object
        Rod rod = new Rod(rodLength, prices);

        //Create service object
        RodCutting cuttingService = new RodCutting();

        //UC1: Optimized revenue using DP
        int maxRevenue = cuttingService.CalculateMaxRevenue(rod);
        Console.WriteLine("Rod Length: " + rodLength);
        Console.WriteLine("Maximum revenue using optimized cutting: " + maxRevenue);

        //UC2 Custom rod length
        Console.WriteLine("\nEnter custom rod length:");
        int customLength = Convert.ToInt32(Console.ReadLine());

        Rod rodB = new Rod(customLength, prices);
        int revenueB = cuttingService.CalculateMaxRevenue(rodB);

        Console.WriteLine("CustomRod Length: " + customLength);
        Console.WriteLine("Maximum revenue: " + revenueB);




    }
}
