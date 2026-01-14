using System;
using System.Diagnostics;
using System.IO;

class FileReadComparison
{
    static void Main(string[] args)
    {
        string filePath = "largefile.txt"; 
        Stopwatch sw = new Stopwatch();

        //Reading using StreamReader
        sw.Start();
        using (StreamReader sr = new StreamReader(filePath))
        {
            while (sr.ReadLine() != null)
            {
            }
        }
        sw.Stop();
        Console.WriteLine("StreamReader Time: " + sw.ElapsedMilliseconds + " ms");

        //Reading using FileStream
        sw.Reset();
        sw.Start();
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[4096];
            while (fs.Read(buffer, 0, buffer.Length) > 0)
            {
            }
        }
        sw.Stop();
        Console.WriteLine("FileStream Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
