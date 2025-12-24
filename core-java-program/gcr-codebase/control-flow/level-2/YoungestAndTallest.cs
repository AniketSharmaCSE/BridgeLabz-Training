using System;

public class YoungestAndTallest
{
    static void Main(string[] args)
    {
        //Input ages for all of them
        Console.WriteLine("Enter Amar age: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Akbar age: ");
        int akbarAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Anthony age: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());


        //Input heights for all of them
        Console.WriteLine("Enter Amar height: ");
        double amarHeight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Akbar height: ");
        double akbarHeight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Anthony height: ");
        double anthonyHeight = Convert.ToDouble(Console.ReadLine());


        //initialise variable with youngest and tallest asumming amar for both
        int youngestAge = amarAge;
        double tallestHeight = amarHeight;



        //Check for youngest age
        if (akbarAge < youngestAge){
            youngestAge = akbarAge;
        }

        if (anthonyAge < youngestAge){
            youngestAge = anthonyAge;
        }


        //Check tallest height
        if (akbarHeight > tallestHeight){
            tallestHeight = akbarHeight;
        }

        if (anthonyHeight > tallestHeight){
            tallestHeight = anthonyHeight;
        }

        Console.WriteLine("Youngest age is: " + youngestAge);
        Console.WriteLine("Tallest height is: " + tallestHeight);
    }
}