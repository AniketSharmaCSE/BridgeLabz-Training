using System;

public class LibraryBookMain
{
    static void Main(string[] args)
    {
        
		//Creating book objects independently
        Book b1 = new Book("CSharp Basics", "Amar");
        Book b2 = new Book("OOP Concepts", "Akbar");
        Book b3 = new Book("DotNet Core", "Anthony");

        //Creating library objects
        Library lib1 = new Library("City Library");
        Library lib2 = new Library("College Library");
		
		
        lib1.AddBook(b1);
        lib1.AddBook(b2);
        lib2.AddBook(b2);
        lib2.AddBook(b3);
        lib1.DisplayBooks();
        lib2.DisplayBooks();
    }
}
