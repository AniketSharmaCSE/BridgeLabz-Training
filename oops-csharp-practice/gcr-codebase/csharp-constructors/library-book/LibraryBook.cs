using System;

public class LibraryBook
{
    string title;
    string author;
    double price;
    bool available;


    //Constructor to initialize book details
    public Book(string title, string author, double price){
        this.title = title;
        this.author = author;
        this.price = price;
        available = true;
    }


    //Method to borrow book
    public void BorrowBook()
    {
        if (available)
        {
            available = false;
            Console.WriteLine("Book borrowed");
        }

        else{
            Console.WriteLine("Book not available");
        }
    }
}
