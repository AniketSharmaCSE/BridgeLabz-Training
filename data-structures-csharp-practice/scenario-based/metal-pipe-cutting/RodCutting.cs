using System;

public class RodCutting
{
    //Method to calculate maximum revenue using DP
    public int CalculateMaxRevenue(Rod rod)
    {
        int rodLength = rod.Length;
        int[] price = rod.Prices;

        int[] dp = new int[rodLength + 1];
        dp[0] = 0;

        for (int i = 1; i <= rodLength; i++)
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

        return dp[rodLength];
    }
}
