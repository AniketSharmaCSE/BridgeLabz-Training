using System;
using System.IO;

class UsingKeyword
{
    static void Main(string[] args)
    {
        try
        {
            //Using StreamReader to ensure file is closed automatically
            using (StreamReader reader = new StreamReader("info.txt"))
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}
