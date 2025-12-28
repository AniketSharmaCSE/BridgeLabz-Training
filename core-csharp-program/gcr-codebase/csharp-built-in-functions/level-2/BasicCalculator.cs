using System;

public class BasicCalculator
{
    //Addition method
    static double Add(double a, double b)
    {
        return a + b;
    }
	

    //Subtraction method
    static double Subtract(double a, double b)
    {
        return a - b;
    }
	
	

    //Multiplication method
    static double Multiply(double a, double b)
    {
        return a * b;
    }

	
	//Division method
    static double Divide(double a, double b)
    {
        return a / b;
    }



    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Choose operation (+ - * /): ");
        char op = Console.ReadLine()[0];

        
        if (op == '+')
        {
            Console.WriteLine(Add(a, b));
        }
        else if (op == '-')
        {
            Console.WriteLine(Subtract(a, b));
        }
        else if (op == '*')
        {
            Console.WriteLine(Multiply(a, b));
        }
        else
        {
            Console.WriteLine(Divide(a, b));
        }
    }
}
