using System;
using System.Collections.Generic;

class FrequencyOfElements
{
    static void Main(string[] args)
    {
        Dictionary<string, int> freq = new Dictionary<string, int>();

        Console.Write("Enter number of items: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter items:");
        for (int i = 0; i < n; i++)
        {
            string item = Console.ReadLine();

            if (freq.ContainsKey(item))
            {
                freq[item]++;
            }
            else
            {
                freq[item] = 1;
            }
        }

        Console.WriteLine("\nFrequency of elements:");
        foreach (var kv in freq)
        {
            Console.WriteLine(kv.Key + " : " + kv.Value);
        }
    }
}
