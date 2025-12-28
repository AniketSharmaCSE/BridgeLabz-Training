using System;

public class DateComparison
{
    //Method to compare two dates
    static void CompareDates(DateTime firstDate, DateTime secondDate)
    {
        //compare using built in CompareTo
        int result = firstDate.CompareTo(secondDate);
        if (result < 0)
        {
            Console.WriteLine("First date is before the second date");
        }
        else if (result > 0)
        {
            Console.WriteLine("First date is after the second date");
        }
        else
        {
            Console.WriteLine("Both dates are the same");
        }
    }



    static void Main(string[] args)
    {
        Console.WriteLine("Enter first date (yyyy-MM-dd): ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter second date (yyyy-MM-dd): ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
		
        CompareDates(firstDate, secondDate);
    }
}
