using System;
using System.Collections;
using System.Collections.Generic;

class ReverseList
{
    static void Main(string[] args)
    {
        //ArrayList
        ArrayList arr = new ArrayList();

        Console.Write("Enter number of elements for ArrayList: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter ArrayList elements:");
        for (int i = 0; i < n1; i++)
        {
            arr.Add(int.Parse(Console.ReadLine()));
        }

        for (int i = 0, j = arr.Count - 1; i < j; i++, j--)
        {
            object temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        Console.WriteLine("Reversed ArrayList:");
        foreach (var x in arr)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine();

        //LinkedList
        LinkedList<int> list = new LinkedList<int>();

        Console.Write("\nEnter number of elements for LinkedList: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter LinkedList elements:");
        for (int i = 0; i < n2; i++)
        {
            list.AddLast(int.Parse(Console.ReadLine()));
        }

        Stack<int> stack = new Stack<int>(list);
        list.Clear();

        while (stack.Count > 0)
        {
            list.AddLast(stack.Pop());
        }

        Console.WriteLine("Reversed LinkedList:");
        foreach (var x in list)
        {
            Console.Write(x + " ");
        }
    }
}
