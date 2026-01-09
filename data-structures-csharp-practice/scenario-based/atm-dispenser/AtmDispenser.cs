using System;
using System.Collections.Generic;

class AtmDispenser
{
    // Method to dispense cash using given notes
    public static void DispenseCash(int amount, int[] notes)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();

        for (int i = notes.Length-1; i >= 0; i--)
        {
            int note = notes[i];

            if (amount >= note)
            {
                int count = amount / note;
                amount = amount % note;
                result[note] = count;
          
		  }

        }


		//Scenario C: Display fallback combo if exact change isn’t possible
        if (amount != 0)
        {
            Console.WriteLine("Exact amount not possible.");
            Console.WriteLine("Fallback combo dispensed:");
        }
		
        else
        {
            Console.WriteLine("Optimal note combination:");
        }

        
		foreach (var item in result)
        {
            Console.WriteLine("Rs. " + item.Key + " * " + item.Value);
        }

        Console.WriteLine("Remaining amount: Rs. " + amount);
    
	}

}
