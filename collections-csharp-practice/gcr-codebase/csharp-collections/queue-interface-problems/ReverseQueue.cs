using System;
using System.Collections.Generic;

class ReverseQueue
{
    static void Main(string[] args)
    {
        Queue<int> q = new Queue<int>();
        Stack<int> s = new Stack<int>();

        Console.Write("Enter number of elements in queue: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter queue elements:");
        for (int i = 0; i < n; i++)
        {
            q.Enqueue(int.Parse(Console.ReadLine()));
        }

        while (q.Count > 0)
        {
            s.Push(q.Dequeue());
        }

        while (s.Count > 0)
        {
            q.Enqueue(s.Pop());
        }

        Console.WriteLine("Reversed Queue:");
        foreach (int x in q)
        {
            Console.Write(x + " ");
        }
    }
}
