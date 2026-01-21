using System;
using System.Collections.Generic;

class HospitalTriageSystem
{
    static void Main(string[] args)
    {
        PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

        Console.Write("Enter number of patients: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter patient name: ");
            string name = Console.ReadLine();

            Console.Write("Enter priority (higher number = more critical): ");
            int priority = int.Parse(Console.ReadLine());

            pq.Enqueue(name, -priority);
        }

        Console.WriteLine("\nTreatment Order:");
        while (pq.Count > 0)
        {
            Console.WriteLine(pq.Dequeue());
        }
    }
}
