using System;

class BookShelvesMain
{
    static void Main(string[] args)
    {
        Library library = new Library();

        while (true)
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Borrow Book");
            Console.WriteLine("3. Show Library");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter Genre: ");
                string genre = Console.ReadLine();

                Console.Write("Enter Book Title: ");
                string title = Console.ReadLine();

                Console.Write("Enter Author: ");
                string author = Console.ReadLine();

                Book book = new Book(title, author);
                library.AddBook(genre, book);

                Console.WriteLine("Book added successfully\n");
            }
            else if (choice == 2)
            {
                Console.Write("Enter Genre: ");
                string genre = Console.ReadLine();

                Console.Write("Enter Book Title: ");
                string title = Console.ReadLine();

                Console.Write("Enter Author: ");
                string author = Console.ReadLine();

                Book book = new Book(title, author);
                library.RemoveBook(genre, book);

                Console.WriteLine();
            }
            else if (choice == 3)
            {
                library.ShowLibrary();
            }
            else if (choice == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice\n");
            }
        }
    }
}
