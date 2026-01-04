using System;

public class BookDetails
{
    static void Main(string[] args)
    {

        //Taking input from user
        Console.WriteLine("Enter book title:");
        string title = Console.ReadLine()
        Console.WriteLine("Enter author name:");
        string author = Console.ReadLine()
        Console.WriteLine("Enter book price:");
        double price = Convert.ToDouble(Console.ReadLine());

      
        Book book = new Book(title, author, price
        book.DisplayDetails();
    }
}
