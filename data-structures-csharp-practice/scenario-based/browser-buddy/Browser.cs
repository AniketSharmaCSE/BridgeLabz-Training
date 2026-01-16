using System;

public class Browser
{
    private TabHistory tabHistory;
    private ClosedTabStack closedTabs;

    public Browser()
    {
        tabHistory = new TabHistory();
        closedTabs = new ClosedTabStack();
    }

    public void OpenPage(string url)
    {
        tabHistory.Visit(url);
    }

    public void Back()
    {
        tabHistory.Back();
    }

    public void Forward()
    {
        tabHistory.Forward();
    }

    public void CloseTab()
    {
        string page = tabHistory.GetCurrentPage();

        if (page != null)
        {
            closedTabs.Push(page);
            tabHistory.CloseCurrent();  
            Console.WriteLine("Closed tab: " + page);
        }
        else
        {
            Console.WriteLine("No tab to close");
        }
    }


    public void RestoreTab()
    {
        if (!closedTabs.IsEmpty())
        {
            string url = closedTabs.Pop();
            tabHistory.Visit(url);
            Console.WriteLine("Restored tab: " + url);
        }
        else
        {
            Console.WriteLine("No tabs to restore");
        }
    }
}
