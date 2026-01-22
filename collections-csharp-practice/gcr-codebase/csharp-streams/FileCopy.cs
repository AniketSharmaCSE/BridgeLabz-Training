using System;
using System.IO;

class FileCopy
{
    static void Main(string[] args)
    {
        Console.Write("Enter source file path: ");
        string sourcePath = Console.ReadLine();
        string destinationPath = "destination.txt";

        //check if source file exists
        if (!File.Exists(sourcePath))
        {
            Console.WriteLine("Source file does not exist.");
            return;
        }

        try
        {
            //FileStream used for reading source file
            FileStream readStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);

            //FileMode.Create ensures destination file is created
            FileStream writeStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write);

            int data;
            while ((data = readStream.ReadByte()) != -1)
            {
                writeStream.WriteByte((byte)data);
            }

            readStream.Close();
            writeStream.Close();

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            //IOException handled for file errors
            Console.WriteLine("File error occurred: " + ex.Message);
        }
    }
}
