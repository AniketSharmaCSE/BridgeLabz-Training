using System;

class Library
{
    private GenreNode[] genres = new GenreNode[10];
    private int count = 0;

    private GenreNode FindGenre(string genre)
    {
        for (int i = 0; i < count; i++)
        {
            if (genres[i].genre == genre)
            {
                return genres[i];
            }
        }
        return null;
    }

    private GenreNode CreateGenre(string genre)
    {
        genres[count] = new GenreNode(genre);
        count++;
        return genres[count - 1];
    }

    public void AddBook(string genre, Book book)
    {
        GenreNode node = FindGenre(genre);
        if (node == null)
        {
            node = CreateGenre(genre);
        }
        node.bookList.AddBook(book);
    }

    public void RemoveBook(string genre, Book book)
    {
        GenreNode node = FindGenre(genre);
        if (node == null)
        {
            Console.WriteLine("Genre not found");
            return;
        }

        bool removed = node.bookList.RemoveBook(book);
        Console.WriteLine(removed ? "Book borrowed successfully" : "Book not found");
    }

    public void ShowLibrary()
    {
        if (count == 0)
        {
            Console.WriteLine("Library is empty");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Genre: " + genres[i].genre);
            genres[i].bookList.ShowBooks();
            Console.WriteLine();
        }
    }
}
