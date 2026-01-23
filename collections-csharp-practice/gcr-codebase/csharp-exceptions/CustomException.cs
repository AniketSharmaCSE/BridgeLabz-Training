using System;

class InvalidAgeException : Exception{}

class CustomException
{
    //Method to validate age and throw custom exception if age is less than 18
    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException();
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            //Calling validation method to check age condition
            ValidateAge(age);

            Console.WriteLine("Access granted!");
        }
        catch (InvalidAgeException)
        {
            Console.WriteLine("Age must be 18 or above");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input");
        }
    }
}
