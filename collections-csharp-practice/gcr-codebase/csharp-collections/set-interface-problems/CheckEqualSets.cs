using System;
using System.Collections.Generic;

class CheckEqualSets
{
    static void Main(string[] args)
    {
        HashSet<int> s1 = new HashSet<int>();
        HashSet<int> s2 = new HashSet<int>();

        Console.Write("Enter number of elements in Set 1: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of Set 1:");
        for (int i = 0; i < n1; i++)
        {
            s1.Add(int.Parse(Console.ReadLine()));
        }

        Console.Write("Enter number of elements in Set 2: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements of Set 2:");
        for (int i = 0; i < n2; i++)
        {
            s2.Add(int.Parse(Console.ReadLine()));
        }

        bool isEqual = s1.SetEquals(s2);

        Console.WriteLine("Are both sets equal? " + isEqual);
    }
}