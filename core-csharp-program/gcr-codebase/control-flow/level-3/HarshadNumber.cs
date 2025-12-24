using System;

public class HarshadNumber
{
    static void Main(string[] args)
    {
        //Ask user for number
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        //Variable to store sum and temporary value
        int sum = 0;
        int temp = number;

        //Calculate sum of digits
        while (temp != 0){
            int digit = temp % 10;
            sum = sum + digit;
            temp = temp / 10;
        }

        //Check Harshad condition
        if (number % sum == 0{
            Console.WriteLine(number + " is a Harshad Number");
        }
        else{
            Console.WriteLine(number + " is not a Harshad Number");
        }
    }
}
