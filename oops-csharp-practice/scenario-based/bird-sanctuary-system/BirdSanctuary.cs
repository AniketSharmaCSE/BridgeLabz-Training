using System;

public class BirdSanctuary
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of birds:");
        int count = Convert.ToInt32(Console.ReadLine());


        Bird[] birds = new Bird[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Choose bird type:");
            Console.WriteLine("1. Eagle");
            Console.WriteLine("2. Sparrow");
            Console.WriteLine("3. Duck");
            Console.WriteLine("4. Penguin");
            Console.WriteLine("5. Seagull");


            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter bird name:");
            string name = Console.ReadLine();

            if (choice == 1)
            {
                birds[i] = new Eagle(name);
            }
            
            else if (choice == 2)
            {
                birds[i] = new Sparrow(name);
            }
            else if (choice == 3)
            {
                birds[i] = new Duck(name);
            }
            else if (choice == 4)
            {
                birds[i] = new Penguin(name);
            }
            
            else if (choice == 5)
            {
                birds[i] = new Seagull(name);
            }
            
            else
            {
                birds[i] = new Bird(name);
            }
        
        }



        for (int i = 0; i < birds.Length; i++)
        {
            birds[i].DisplayBird();

            if (birds[i] is IFlyable)
            {
                ((IFlyable)birds[i]).Fly();
          
            }

            
            if (birds[i] is ISwimmable)
            {
                ((ISwimmable)birds[i]).Swim();
            }

            
            Console.WriteLine();
        }
 
    }

}


