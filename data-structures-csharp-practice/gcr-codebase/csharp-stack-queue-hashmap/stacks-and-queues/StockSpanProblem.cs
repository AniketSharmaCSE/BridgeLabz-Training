using System;
using System.Collections.Generic;

class StockSpanProblem
{
    static void CalculateSpan(int[] prices)
    {
        Stack<int> stack = new Stack<int>();
        int[] span = new int[prices.Length];

        stack.Push(0);
        span[0] = 1;

        for (int i = 1; i < prices.Length; i++)
        {
            // Pop indices with smaller or equal price
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }
            span[i] = stack.Count == 0 ? i + 1 : i - stack.Peek();
            stack.Push(i);
        }

        
		Console.WriteLine("Stock Span:");
        for (int i = 0; i < span.Length; i++)
        {
            Console.Write(span[i] + " ");
        }
    
	}

    static void Main()
    {
        Console.Write("Enter number of days: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] prices = new int[n];
        Console.WriteLine("Enter stock prices:");
    
		for (int i = 0; i < n; i++)
        {
            prices[i] = Convert.ToInt32(Console.ReadLine());
        }

        CalculateSpan(prices);
    }

}
