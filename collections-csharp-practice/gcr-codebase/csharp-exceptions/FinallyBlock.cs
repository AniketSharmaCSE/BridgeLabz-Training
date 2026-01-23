using System;

class FinallyBlock
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            //Performing division operation
            int result = a / b;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input");
        }
        finally
        {
            //This block always executes whether exception occurs or not
            Console.WriteLine("Operation completed");
        }
    }
}
