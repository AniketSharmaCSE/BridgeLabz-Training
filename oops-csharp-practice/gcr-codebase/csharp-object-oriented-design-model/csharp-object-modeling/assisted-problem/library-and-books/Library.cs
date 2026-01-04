using System.*;

public class Library
{
    string libraryName;
    List<Book> books;


    public Library(string libraryName)
    {
        this.libraryName = libraryName;
        books = new List<Book>();
    }



    //Method to add book to library
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    //Method to display all books in library
    public void DisplayBooks()
    {
        Console.WriteLine("Library: " + libraryName);
        foreach (Book book in books){
            book.DisplayBook();
        }
    }
}
