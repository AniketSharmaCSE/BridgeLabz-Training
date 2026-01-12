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
}
