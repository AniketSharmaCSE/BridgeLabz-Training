using System;

public class LibraryManagement
{
    //Book object to store details
    class Book
    {
        public string title;
        public string author;
        public bool isAvailable;
    }


    //Method to add book 
    static void AddBook(Book[] books)
    {
        int position = -1;
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == null)
            {
                position = i;
                break;
            }
        }

        if (position == -1)
        {
            Console.WriteLine("Library is full");
        }
        else
        {
            Console.WriteLine("Enter book title:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter author name:");
            string author = Console.ReadLine();

            books[position] = new Book();
            books[position].title = title;
            books[position].author = author;
            books[position].isAvailable = true;

            Console.WriteLine("Book added successfully");
        }
    }


    //Method to remove a book
    static void RemoveBook(Book[] books)
    {
        DisplayBooks(books);
        Console.WriteLine("Enter book number to remove:");
        int choice = Convert.ToInt32(Console.ReadLine()) - 1;

        books[choice] = null;
        Console.WriteLine("Book removed successfully");
    }


    //Method to display books
    static void DisplayBooks(Book[] books)
    {
        bool isEmpty = false;

        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] != null)
            {
                Console.WriteLine((i + 1) + ". " + books[i].title + " by " + books[i].author + " Status: " + (books[i].isAvailable ? "Available" : "Checked Out"));
                isEmpty = true;
            }
        }

        if (isEmpty == false)
        {
            Console.WriteLine("No books available in library");
        }
    }


    //Method to search book 
    static void SearchBook(Book[] books)
    {
        Console.WriteLine("Enter keyword to search:");
        string keyword = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] != null && books[i].title.ToLower().Contains(keyword.ToLower()))
            {
                Console.WriteLine(books[i].title + " by " + books[i].author + " Status: " + (books[i].isAvailable ? "Available" : "Checked Out"));
                found = true;
            }
        }

        if (found == false)
        {
            Console.WriteLine("No book found with that title");
        }
    }


    //Method to borrow a book
    static void BorrowBook(Book[] books)
    {
        DisplayBooks(books);
        Console.WriteLine("Enter book number to borrow:");
        int choice = Convert.ToInt32(Console.ReadLine()) - 1;

        if (books[choice].isAvailable == false)
        {
            Console.WriteLine("Book already borrowed");
        }
        else
        {
            books[choice].isAvailable = false;
            Console.WriteLine("Book borrowed successfully");
        }
    }

    //Admin menu
    static int AdminMenu(Book[] books)
    {
        int option;
        Console.WriteLine("1.Add Book");
        Console.WriteLine("2.Remove Book");
        Console.WriteLine("3.Display Book");
        Console.WriteLine("4.Search Book");
        Console.WriteLine("5.Switch Role");
        Console.WriteLine("6.Exit");
        Console.WriteLine("Enter your choice:");
        option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                AddBook(books);
                break;
            case 2:
                RemoveBook(books);
                break;
            case 3:
                DisplayBooks(books);
                break;
            case 4:
                SearchBook(books);
                break;
            case 5:
                return 0;
            case 6:
                return -1;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }

        return 1;
    }

    //User menu
    static int UserMenu(Book[] books)
    {
        int option;

        Console.WriteLine("1.Display Books");
        Console.WriteLine("2.Search Book");
        Console.WriteLine("3.Borrow Book");
        Console.WriteLine("4.Switch Role");
        Console.WriteLine("5.Exit");
        Console.WriteLine("Enter your choice:");
        option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                DisplayBooks(books);
                break;
            case 2:
                SearchBook(books);
                break;
            case 3:
                BorrowBook(books);
                break;
            case 4:
                return 0;
            case 5:
                return -1;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }

        return 2;
    }

    //Main controller
    static void AccessLibrary()
    {
        Book[] books = new Book[100];
        int role = 0;
        bool running = true;

        while (running)
        {
            if (role == 0)
            {
                Console.WriteLine("Select Role: 1.Admin  2.User");
                role = Convert.ToInt32(Console.ReadLine());
            }
            else if (role == 1)
            {
                int result = AdminMenu(books);
                if (result == 0) { role = 0; }
                if (result == -1) { running = false; }
            }
            else if (role == 2)
            {
                int result = UserMenu(books);
                if (result == 0) { role = 0; }
                if (result == -1) { running = false; }
            }
        }

        Console.WriteLine("Library system closed");
    }

    static void Main(string[] args)
    {
        AccessLibrary();
    }
}
