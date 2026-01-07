using System;

public abstract class LibraryItem
{
    private int itemId;
    private string title;
    private string author;

    public int ItemId
    {
        get 
        {
             return itemId; 
        }
        set
        {
             itemId = value;
        }
    }

    public string Title
    {
        get 
        {
             return title; 
        }
        set
         {
             title = value; 
        }
    
    }

    public string Author
    {
        get 
        {
             return author;
        }
        set 
        {
             author = value;
         }
    }

    public abstract int GetLoanDuration();

    public void GetItemDetails()
    {
        Console.WriteLine("Item Id: " + itemId);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Loan Duration (Days): " + GetLoanDuration());
    }

}
