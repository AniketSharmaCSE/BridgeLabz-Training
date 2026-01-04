using System;

public class Book
{
    string title;
    string author;
    double price;

   
    //Constructor to initialize book details
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    
   //Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price:" + price);
    }
}
