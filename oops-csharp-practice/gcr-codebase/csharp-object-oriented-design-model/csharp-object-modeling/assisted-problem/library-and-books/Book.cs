using System;

public class Book
{
    string title;
    string author;

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }


    public void DisplayBook()
    {
        Console.WriteLine(title + "by " + author);
    }
}
