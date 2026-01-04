using System;

public class LibraryBookMain
{
    static void Main(string[] args)
    {
	
        //Creating book object
        Book book = new Book("CSharp", "anthony", 400);

        book.BorrowBook();
        book.BorrowBook();
    }
}
