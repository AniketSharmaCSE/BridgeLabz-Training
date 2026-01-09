using System;
using System.Collections.Generic;

class PairWithGivenSum
{
    static bool HasPair(int[] arr, int target)
    {
        Dictionary<int, bool> map = new Dictionary<int, bool>();

        for (int i = 0; i < arr.Length; i++)
        {
            int required = target - arr[i];

            // If required value already exists, pair found
            if (map.ContainsKey(required))
            {
                return true;

            }

            map[arr[i]] = true;
        }

        return false;

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
		Console.WriteLine(HasPair(arr, target) ? "Pair exists" : "Pair does not exist");

    }
}
