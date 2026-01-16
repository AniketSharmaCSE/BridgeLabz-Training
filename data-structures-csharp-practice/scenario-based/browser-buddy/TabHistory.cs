using System;

public class TabHistory
{
    private HistoryNode current;

    public void Visit(string url)
    {
        HistoryNode node = new HistoryNode(url);

        if (current != null)
        {
            current.Next = node;
            node.Prev = current;
        }

        current = node;
        Console.WriteLine("Opened: " + current.Url);
    }

    public void Back()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Current: " + current.Url);
        }
        else
        {
            Console.WriteLine("No back history");
        }
    }

    public void Forward()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Current: " + current.Url);
        }
        else
        {
            Console.WriteLine("No forward history");
        }
    }

    public string GetCurrentPage()
    {
        if (current != null)
        {
            return current.Url;
        }
        return null;
    }

    public void CloseCurrent()
    {
        if (current == null)
        {
            return;
        }

        HistoryNode toDelete = current;

        if (current.Prev != null)
        {
            current.Prev.Next = current.Next;
        }

        if (current.Next != null)
        {
            current.Next.Prev = current.Prev;
        }

        if (current.Next != null)
        {
            current = current.Next;
        }
        else
        {
            current = current.Prev;
        }

        toDelete.Next = null;
        toDelete.Prev = null;
    }

}
