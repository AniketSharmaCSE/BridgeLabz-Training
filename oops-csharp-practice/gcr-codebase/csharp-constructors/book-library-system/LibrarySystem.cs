using System;

public class LibrarySystem
{
    static void Main(string[] args)
    {
        //Taking user input
        Console.WriteLine("Enter ISBN:");
        string isbn = Console.ReadLine();
        Console.WriteLine("Enter book title:");
        string title = Console.ReadLine();
        Console.WriteLine("Enter author name:");
        string author = Console.ReadLine();


        EBook ebook = new EBook(isbn, title, author);
        ebook.DisplayEBookDetails();


        Console.WriteLine("Author: " + ebook.GetAuthor());
        Console.WriteLine("Enter new author name:");
        string newAuthor = Console.ReadLine();

        ebook.SetAuthor(newAuthor);
        Console.WriteLine("Updated Author: " + ebook.GetAuthor());
    }
}
