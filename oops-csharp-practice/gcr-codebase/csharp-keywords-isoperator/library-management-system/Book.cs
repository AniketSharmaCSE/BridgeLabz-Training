using System;

public class Book
{
    //Static variable
    public static string LibraryName = "Central Library";

    string title;
    string author;
    readonly string isbn;

    //Constructor using this keyword and readonly ISBN
    public Book(string title, string author, string isbn)
    {
        this.title = title;
        this.author = author;
        this.isbn = isbn;
    }


    //Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("ISBN: " + isbn);
  
  }


    //Static method to display library name
    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library Name: " + LibraryName);
    }
}
