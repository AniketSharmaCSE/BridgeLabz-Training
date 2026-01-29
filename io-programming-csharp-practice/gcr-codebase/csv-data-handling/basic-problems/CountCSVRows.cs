using System;
using System.IO;

class CountCSVRows
{
    static void Main(string[] args)
    {
        string path = "students.csv";

        string[] lines = File.ReadAllLines(path);

        //Total rows minus header row
        int recordCount = lines.Length - 1;

        Console.WriteLine("Total Records: " + recordCount);
    }
}
