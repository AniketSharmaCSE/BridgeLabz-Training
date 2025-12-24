using System;

public class AbundantNumber
{
    static void Main(string[] args)
    {
        //Input a number from user
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        //Variable to store sum
        int sum = 0;

        //Find sum of divisors
        for (int i = 1; i < number; i++){
            if (number % i == 0){
                sum = sum + i;
            }
        }
        //Check if abundant number 
        if (sum > number){
            Console.WriteLine(number + " is an Abundant Number");
        }
        else{
            Console.WriteLine(number + " is not an Abundant Number");
        }
    }
}
