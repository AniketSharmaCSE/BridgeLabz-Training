using System;
using System.Collections.Generic;

class SymmetricDifference
{
    static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();

        Console.Write("Enter number of elements in Set 1: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of Set 1:");
        for (int i = 0; i < n1; i++)
        {
            set1.Add(int.Parse(Console.ReadLine()));
        }

        Console.Write("Enter number of elements in Set 2: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of Set 2:");
        for (int i = 0; i < n2; i++)
        {
            set2.Add(int.Parse(Console.ReadLine()));
        }

        set1.SymmetricExceptWith(set2);

        Console.WriteLine("Symmetric Difference:");
        foreach (int x in set1)
        {
            Console.Write(x + " ");
        }
    }
}
