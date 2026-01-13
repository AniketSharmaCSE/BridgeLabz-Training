using System;
using System.IO;

class ByteToCharacterStream
{
    //Method to read byte stream and convert to character stream
    static void ReadBinaryAsText(string filePath)
    {
        FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(fs);

        int ch;

        while ((ch = reader.Read()) != -1)
        {
            Console.Write((char)ch);
        }
    }
	

    static void Main(string[] args)
    {
        Console.WriteLine("Enter file path:");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            ReadBinaryAsText(filePath);
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}
