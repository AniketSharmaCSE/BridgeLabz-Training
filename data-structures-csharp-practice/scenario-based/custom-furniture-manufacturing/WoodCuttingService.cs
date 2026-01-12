public class WoodCuttingService
{
    // Method to calculate maximum revenue using DP
    public int CalculateMaxRevenue(Wood wood)
    {
        int n = wood.WoodLength;
        int[] price = wood.Prices;

        int[] dp = new int[n + 1];
        dp[0] = 0;

        for (int i = 1; i <= n; i++)
        {
            int max = int.MinValue;

            for (int j = 1; j <= i; j++)
            {
                int currentValue = price[j] + dp[i - j];
                if (currentValue > max)
                {
                    max = currentValue;
                }
            }

            dp[i] = max;
        }

        return dp[n];
    }

    //UC2: Method to calclulate revenue when waste constraint is introduced
    public int CalculateRevenueWithWasteConstraint(int woodLength, int maxAllowedWaste, int[] prices)
    {
        int bestRevenue = 0;

        for (int usedLength = woodLength;
             usedLength >= woodLength - maxAllowedWaste;
             usedLength--)
        {
            Wood tempWood = new Wood(usedLength, prices);
            int revenue = CalculateMaxRevenue(tempWood);

            if (revenue > bestRevenue)
            {
                bestRevenue = revenue;
            }
        }

        return bestRevenue;
    }

    //UC3: Method to calculate maximizing revenue with minimum waste
    public int CalculateBestRevenueWithMinimumWaste(int woodLength, int[] prices, out int waste)
    {
        int bestRevenue = 0;
        waste = woodLength;

        for (int usedLength = woodLength; usedLength >= 0; usedLength--)
        {
            Wood tempWood = new Wood(usedLength, prices);
            int revenue = CalculateMaxRevenue(tempWood);
            int currentWaste = woodLength - usedLength;

            if (revenue > bestRevenue ||
               (revenue == bestRevenue && currentWaste < waste))
            {
                bestRevenue = revenue;
                waste = currentWaste;
            }
        }

        return bestRevenue;
    }



}
