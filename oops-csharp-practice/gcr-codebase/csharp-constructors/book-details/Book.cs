using System;

public class Book
{
    string title;
    string author;
    double price;
    


    //Default constructor
    public Book()
    {
        title = "Not Assigned";
        author = "Unknown";
        price = 0;
    }


    //Parameterized constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }


    //Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine(title + " " + author + " " + price);
    }
}
