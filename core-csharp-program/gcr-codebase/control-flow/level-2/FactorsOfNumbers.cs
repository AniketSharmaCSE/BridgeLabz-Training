using System;

public class FactorsOfNumber
{
    static void Main(string[] args)
    {
        //Ask user for a number
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());


        //Check factors of the numbers using for loop
        for (int i = 1; i < number; i++){
            if (number % i == 0){
                Console.WriteLine(i);
            }
        }
    }
}
