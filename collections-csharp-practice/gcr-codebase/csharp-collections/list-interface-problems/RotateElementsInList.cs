using System;
using System.Collections.Generic;

class RotateElementsInList
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter list elements:");
        for (int i = 0; i < n; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }

        Console.Write("Enter rotation value k: ");
        int k = int.Parse(Console.ReadLine());

        k = k % list.Count;

        List<int> result = new List<int>();
        result.AddRange(list.GetRange(k, list.Count - k));
        result.AddRange(list.GetRange(0, k));

        Console.WriteLine("List after rotation:");
        foreach (int x in result)
        {
            Console.Write(x + " ");
        }
    }
}
