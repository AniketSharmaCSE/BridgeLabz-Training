using System;

class Library
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter book title:");
        string title = Console.ReadLine();
        Console.WriteLine("Enter publication year:");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter author name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter author bio:");
        string bio = Console.ReadLine();

        Book book = new Author(title, year, name, bio);

        Console.WriteLine("Book Information:");
        book.DisplayInfo();
    }
}
