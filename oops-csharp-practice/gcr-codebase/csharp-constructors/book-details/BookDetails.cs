using System;

public class BookDetails
{
    static void Main(string[] args)
    {
        //Creating object using default constructor
        Book b1 = new Book();

        //Creating object using parameterized constructor
        Book b2 = new Book("CSharp Basics", "Microsoft", 500);

        b1.DisplayDetails();
        b2.DisplayDetails();
    }
}
