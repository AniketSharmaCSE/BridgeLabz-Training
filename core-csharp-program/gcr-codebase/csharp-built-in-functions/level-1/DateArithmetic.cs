using System;

public class DateArithmetic
{
	
    //Method to perform date arithmetic operations
    static DateTime PerformDateOperations(DateTime date)
    {
        //add 7 days
        date = date.AddDays(7);

        //add 1 month
        date = date.AddMonths(1);

        //add 2 years
        date = date.AddYears(2);

        //subtract 3 weeks
        date = date.AddDays(-21);

        return date;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Enter date (yyyy-MM-dd): ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());
        
        DateTime resultDate = PerformDateOperations(inputDate);

        Console.WriteLine("Final date after operations:");
        Console.WriteLine(resultDate.ToShortDateString());
    }
}
