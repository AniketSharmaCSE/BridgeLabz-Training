using System;
using System.IO;

class LargeFileReader
{
    static void Main(string[] args)
    {
        Console.Write("Enter file path: ");
        string filePath = Console.ReadLine();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        try
        {
            //StreamReader used to read large file line by line
            StreamReader reader = new StreamReader(filePath);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                //case insensitive check for word "error"
                if (line.ToLower().Contains("error"))
                {
                    Console.WriteLine(line);
                }
            }

            reader.Close();
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error occurred: " + ex.Message);
        }
    }
}
