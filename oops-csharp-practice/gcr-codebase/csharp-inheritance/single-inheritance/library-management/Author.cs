using System;

class Author : Book
{
    public string Name;
    public string Bio;

    public Author(string title, int publicationYear, string name, string bio)
        : base(title, publicationYear)
    {
        Name = name;
        Bio = bio;
    }

    //Override to display author specific details
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Author Name: " + Name);
        Console.WriteLine("Author Bio: " + Bio);
    }
}
