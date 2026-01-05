using System;

public class Book
{
    public string ISBN;
    protected string title;
    private string author;

    //Constructor to initialize book details
    public Book(string ISBN, string title, string author)
    {
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;    }


    //Public method to get author name
    public string GetAuthor()
    {
        return author;
    }


    //Public method to set author name
    public void SetAuthor(string author)
    {
        this.author = author;
    }
}
