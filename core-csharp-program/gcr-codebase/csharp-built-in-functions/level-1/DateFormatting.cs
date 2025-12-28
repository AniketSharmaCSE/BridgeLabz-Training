using System;

public class DateFormatting
{
    //Method to display date in different formats
    static void DisplayFormattedDates(DateTime date)
    {
        //dd/MM/yyyy format
        Console.WriteLine(date.ToString("dd/MM/yyyy"));

        //yyyy-MM-dd format
        Console.WriteLine(date.ToString("yyyy-MM-dd"));

        //EEE, MMM dd, yyyy format
        Console.WriteLine(date.ToString("ddd, MMM dd, yyyy"));
    }



    static void Main(string[] args)
    {
        DateTime currentDate = DateTime.Now;        
        Console.WriteLine("Current date in different formats:");
        DisplayFormattedDates(currentDate);
    }
}
