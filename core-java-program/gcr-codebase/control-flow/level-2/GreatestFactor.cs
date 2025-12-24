using System;

public class GreatestFactor
{
    static void Main(string[] args)
    {
        //Take input from user
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        //initialise variable with greatest factor 1
        int greatestFactor = 1;

        //Loop from number-1 to 1
        for (int i = number - 1; i >= 1; i--){
            if (number % i == 0){
                greatestFactor = i;
                break;
            }
        }


        //print the greatest factor
        Console.WriteLine("Greatest factor is: " + greatestFactor);
    }
}
