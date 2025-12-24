using System;

public class Calculator
{
    static void Main(string[] args)
    {
        //Ask user for operands
        Console.WriteLine("Enter first number: ");
        double first = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        double second = Convert.ToDouble(Console.ReadLine());

        //input the operator
        Console.WriteLine("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();


        //Perform operation using switch
        switch (op)
        {
            case "+":
                Console.WriteLine("Result: " + (first + second));
                break;

            case "-":
                Console.WriteLine("Result: " + (first - second));
                break;

            case "*":
                Console.WriteLine("Result: " + (first * second));
                break;

            case "/":
                Console.WriteLine("Result: " + (first / second));
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
