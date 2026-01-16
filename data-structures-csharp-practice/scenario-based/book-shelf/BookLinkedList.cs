using System;

class BookLinkedList
{
    private BookNode head;

    public void AddBook(Book book)
    {
        BookNode node = new BookNode(book);
        node.next = head;
        head = node;
    }

    public bool RemoveBook(Book book)
    {
        BookNode current = head;
        BookNode prev = null;

        while (current != null)
        {
            if (current.book.Equals(book))
            {
                if (prev == null)
                {
                    head = current.next;
                }
                else
                {
                    prev.next = current.next;
                }
                return true;
            }
            prev = current;
            current = current.next;
        }
        return false;
    }

    public void ShowBooks()
    {
        if (head == null)
        {
            Console.WriteLine("No books available");
            return;
        }

        BookNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.book.GetTitle() + " by " + temp.book.GetAuthor());
            temp = temp.next;
        }
    }
}
