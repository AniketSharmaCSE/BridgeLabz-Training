using System;
using System.Collections.Generic;

class NthElementFromEnd
{
    static void Main(string[] args)
    {
        LinkedList<string> list = new LinkedList<string>();

        Console.Write("Enter number of elements in list: ");
        int size = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < size; i++)
        {
            list.AddLast(Console.ReadLine());
        }

        Console.Write("Enter N (nth element from end): ");
        int n = int.Parse(Console.ReadLine());

        var first = list.First;
        var second = list.First;

        for (int i = 0; i < n; i++)
        {
            if (first == null)
            {
                Console.WriteLine("N is greater than list length");
                return;
            }
            first = first.Next;
        }

        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }

        Console.WriteLine("Nth element from end: " + second.Value);
    }
}
