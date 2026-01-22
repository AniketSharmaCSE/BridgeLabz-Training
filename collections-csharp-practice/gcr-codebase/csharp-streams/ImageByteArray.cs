using System;
using System.IO;

class ImageByteArray
{
    static void Main(string[] args)
    {
        Console.Write("Enter source image path: ");
        string sourcePath = Console.ReadLine();

        string destinationPath = "copiedImage.jpg";

        if (!File.Exists(sourcePath))
        {
            Console.WriteLine("Source image does not exist.");
            return;
        }

        try
        {
            //read image file into byte array
            byte[] imageBytes = File.ReadAllBytes(sourcePath);

            //store byte array in memory
            MemoryStream ms = new MemoryStream(imageBytes);

            //write byte array back to new image file
            FileStream fs = new FileStream(destinationPath, FileMode.Create, FileAccess.Write);
            ms.WriteTo(fs);

            fs.Close();
            ms.Close();

            //verify both files are identical by size
            FileInfo original = new FileInfo(sourcePath);
            FileInfo copied = new FileInfo(destinationPath);

            if (original.Length == copied.Length)
            {
                Console.WriteLine("Image copied successfully and verified.");
            }
            else
            {
                Console.WriteLine("Image copy failed verification.");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error occurred: " + ex.Message);
        }
    }
}
