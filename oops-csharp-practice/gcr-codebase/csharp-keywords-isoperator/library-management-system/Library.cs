using System;

public class Library
{
    static void Main(string[] args)
    {
        //Taking user input
        Console.WriteLine("Enter book title:");
        string title = Console.ReadLine();
        Console.WriteLine("Enter author name:");
        string author = Console.ReadLine();
        Console.WriteLine("Enter ISBN:");
        string isbn = Console.ReadLine();


        Book book = new Book(title, author, isbn);

        //Calling static method
        Book.DisplayLibraryName();
        
		
		//Using is operator before displaying details
        if (book is Book)
        {
            book.DisplayDetails();
        }
    }
}
