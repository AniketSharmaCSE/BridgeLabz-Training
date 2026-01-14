using System;
using System.Diagnostics;
using System.Text;

class StringConcatComparison
{
    static void Main(string[] args)
    {
        int n = 100000;
        Stopwatch sw = new Stopwatch();

        //Using string concatenation
        string s = "";
        sw.Start();
        for (int i = 0; i < n; i++)
        {
            s = s + "a";
        }
        sw.Stop();
        Console.WriteLine("String Concatenation Time: " + sw.ElapsedMilliseconds + " ms");


        //Using StringBuilder
        StringBuilder sb = new StringBuilder();
        sw.Reset();
        sw.Start();
        for (int i = 0; i < n; i++)
        {
            sb.Append("a");
        }
        sw.Stop();
        Console.WriteLine("StringBuilder Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
