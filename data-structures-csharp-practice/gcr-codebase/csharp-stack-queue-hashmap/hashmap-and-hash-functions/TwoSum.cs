using System;
using System.Collections.Generic;

class TwoSum
{
    static void FindTwoSum(int[] arr, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int required = target - arr[i];

            // If required value exists, indices found
            if (map.ContainsKey(required))
            {
                Console.WriteLine("Indices: " + map[required] + " and " + i);
                return;
            }

            map[arr[i]] = i;
       
	   }

        Console.WriteLine("No two sum solution");

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

        Console.Write("Enter target sum: ");
        int target = Convert.ToInt32(Console.ReadLine());

        FindTwoSum(arr, target);

    }
}
