using System;

class CircularTourProblem
{
    static int FindStartingPoint(int[] petrol, int[] distance)
    {
        int start = 0;
        int surplus = 0;
        int deficit = 0;

        for (int i = 0; i < petrol.Length; i++)
        {
            // Track petrol surplus
            surplus += petrol[i] - distance[i];

            if (surplus < 0)
            {
                start = i + 1;
                deficit += surplus;
                surplus = 0;
        
			}
        
		}

        return (surplus + deficit >= 0) ? start : -1;
    
	}

    
	static void Main()
    {
        Console.Write("Enter number of petrol pumps: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] petrol = new int[n];
        int[] distance = new int[n];

        Console.WriteLine("Enter petrol at each pump:");
        for (int i = 0; i < n; i++)
        {
            petrol[i] = Convert.ToInt32(Console.ReadLine());
        }

    
    Console.WriteLine("Enter distance to next pump:");
        for (int i = 0; i < n; i++)
        {
            distance[i] = Convert.ToInt32(Console.ReadLine());
        }

        int result = FindStartingPoint(petrol, distance);


        if (result == -1)
        {
            Console.WriteLine("No possible tour");
        }
        else
        {
            Console.WriteLine("Start from pump index: " + result);

        }

    }

}
