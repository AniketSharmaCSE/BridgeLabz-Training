using System;
using System.Collections.Generic;

class WordFrequencyCounter
{
    static void Main(string[] args)
    {
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();

        string[] words = text
            .ToLower()
            .Replace(",", "")
            .Replace("!", "")
            .Replace(".", "")
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> map = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (map.ContainsKey(word))
            {
                map[word]++;
            }
            else
            {
                map[word] = 1;
            }
        }

        Console.WriteLine("\nWord Frequencies:");
        foreach (var kv in map)
        {
            Console.WriteLine(kv.Key + " : " + kv.Value);
        }
    }
}
