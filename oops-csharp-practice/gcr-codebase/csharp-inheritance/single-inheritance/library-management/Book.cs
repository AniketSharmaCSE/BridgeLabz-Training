using System;

class Book
{
    public string Title;
    public int PublicationYear;

    public Book(string title, int publicationYear)
    {
        Title = title;
        PublicationYear = publicationYear;
    }

    //Method to display book details
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Book Title: " + Title);
        Console.WriteLine("Publication Year: " + PublicationYear);
    }
}
