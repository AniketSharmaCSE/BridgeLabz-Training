using System;
using System.IO;

class UserInputToFile
{
    static void Main(string[] args)
    {
        try
        {
            //StreamReader used to read input from console
            StreamReader reader = new StreamReader(Console.OpenStandardInput());

            Console.Write("Enter your name: ");
            string name = reader.ReadLine();

            Console.Write("Enter your age: ");
            string age = reader.ReadLine();

            Console.Write("Enter your favorite programming language: ");
            string language = reader.ReadLine();

            //StreamWriter used to write user data into file
            StreamWriter writer = new StreamWriter("userInfo.txt");

            writer.WriteLine("Name: " + name);
            writer.WriteLine("Age: " + age);
            writer.WriteLine("Favorite Language: " + language);

            writer.Close();
            reader.Close();

            Console.WriteLine("User information saved successfully.");
        }
        catch (Exception ex)
        {
            //handling input/output related exceptions
            Console.WriteLine("Error occurred: " + ex.Message);
        }
    }
}
