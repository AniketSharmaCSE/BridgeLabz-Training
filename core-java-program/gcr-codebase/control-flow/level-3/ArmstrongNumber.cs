using System;

public class ArmstrongNumber
{
    static void Main(string[] args)
    {
        //Input a number from the user
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        //variable to store original number and sum
        int originalNumber = number;
        int sum = 0;


        //While loop to Find sum of cubes of digits
        while (originalNumber != 0){
            int digit = originalNumber % 10;
            sum = sum + (digit * digit * digit);
            originalNumber = originalNumber / 10;
        }

        
        //Check Armstrong condition
        if (sum == number){
            Console.WriteLine(number + " is an Armstrong Number");
        }
        else{
            Console.WriteLine(number + " is not an Armstrong Number");
        }
    }
}
