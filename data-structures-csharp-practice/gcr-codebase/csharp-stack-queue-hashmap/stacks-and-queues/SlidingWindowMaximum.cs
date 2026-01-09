using System;
using System.Collections.Generic;

class SlidingWindowMaximum
{
    static void FindMaximum(int[] arr, int k)
    {
        LinkedList<int> deque = new LinkedList<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            // Remove indices outside current window
            while (deque.Count > 0 && deque.First.Value <= i - k)
            {
                deque.RemoveFirst();
            }

            // Remove smaller elements from back
            while (deque.Count > 0 && arr[deque.Last.Value] <= arr[i])
            {
                deque.RemoveLast();
            }

            deque.AddLast(i);

            if (i >= k - 1)
            {
                Console.Write(arr[deque.First.Value] + " ");
         
			}

        }

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

        Console.Write("Enter window size: ");
        int k = Convert.ToInt32(Console.ReadLine());

        FindMaximum(arr, k);
    }
}
