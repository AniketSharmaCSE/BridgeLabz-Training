using System;
using System.Collections.Generic;

class ZeroSumSubarrayCount
{
    // Method to count zero sum subarrays
    static void CountZeroSumSubarrays(int[] arr)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int sum = 0;
        int count = 0;


        // Initial sum 0 with frequency 1
        map[0] = 1;


        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            // If sum exists, add its frequency to count
            if (map.ContainsKey(sum))
            {
                count += map[sum];
                map[sum]++;

            }
            else
            {
                map[sum] = 1;
            }
        }
        Console.WriteLine("Total zero sum subarrays: " + count);

    }

    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());

        }

        CountZeroSumSubarrays(arr);
    }
}
