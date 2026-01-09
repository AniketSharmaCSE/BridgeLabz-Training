using System;
using System.Collections.Generic;

class SortStackRecursion
{
    static void InsertSorted(Stack<int> stack, int value)
    {
        // Insert element at correct position in sorted stack
        if (stack.Count == 0 || stack.Peek() <= value)
        {
            stack.Push(value);
            return;
        }

        int temp = stack.Pop();
        InsertSorted(stack, value);
        stack.Push(temp);
    }

   
   static void SortStack(Stack<int> stack)
    {
        // Recursively sort remaining stack
        if (stack.Count == 0)
        {
            return;
        }

        int temp = stack.Pop();
        SortStack(stack);
        InsertSorted(stack, temp);
    }


    static void Main()
    {
        Stack<int> stack = new Stack<int>();

        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            stack.Push(Convert.ToInt32(Console.ReadLine()));
        
		}

        SortStack(stack);

        Console.WriteLine("Sorted Stack:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        
		}
   
   }

}
