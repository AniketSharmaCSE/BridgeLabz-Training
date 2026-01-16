class Book
{
    private string title;
    private string author;

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        Book other = obj as Book;
        if (other == null)
        {
            return false;
        }

        return title == other.title && author == other.author;
    }
}
