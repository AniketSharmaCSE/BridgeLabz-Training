using System;
using System.Collections.Generic;

class QueueUsingStacks
{
    static Stack<int> stackEnq = new Stack<int>();
    static Stack<int> stackDeq = new Stack<int>();


    // Method to add element to queue
    static void Enqueue(int value)
    {
        stackEnq.Push(value);
        Console.WriteLine("Enqueued: " + value);
    }


    // Method to remove element from queue
    static void Dequeue()
    {
        // Transfer elements only when dequeue stack is empty
        if (stackDeq.Count == 0)
        {
            while (stackEnq.Count > 0)
            {
                stackDeq.Push(stackEnq.Pop());
            }
			
        }

        if (stackDeq.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("Dequeued: " + stackDeq.Pop());
        
		}
  
  }
	

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());
           
		   if (choice == 1)
            {
                Console.Write("Enter value: ");
                int value = Convert.ToInt32(Console.ReadLine());
                Enqueue(value);
            }
           
		   else if (choice == 2)
            {
                Dequeue();
            }
            else if (choice == 3)
            {
                break;
            }
            else
            {
          
		  Console.WriteLine("Invalid choice");
     
	 }
     
	 }
    }
}
