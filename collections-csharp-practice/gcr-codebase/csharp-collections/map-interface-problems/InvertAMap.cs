using System;
using System.Collections.Generic;

class InvertAMap
{
    static void Main(string[] args)
    {
        Dictionary<string, int> input = new Dictionary<string, int>();

        Console.Write("Enter number of entries: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter key: ");
            string key = Console.ReadLine();

            Console.Write("Enter value: ");
            int value = int.Parse(Console.ReadLine());

            input[key] = value;
        }

        Dictionary<int, List<string>> result = new Dictionary<int, List<string>>();

        foreach (var kv in input)
        {
            if (!result.ContainsKey(kv.Value))
            {
                result[kv.Value] = new List<string>();
            }

            result[kv.Value].Add(kv.Key);
        }

        Console.WriteLine("\nInverted Map:");
        foreach (var kv in result)
        {
            Console.Write(kv.Key + " : ");
            foreach (string v in kv.Value)
            {
                Console.Write(v + " ");
            }
            Console.WriteLine();
        }
    }
}
