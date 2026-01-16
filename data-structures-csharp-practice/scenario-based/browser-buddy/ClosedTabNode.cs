using System;

public class ClosedTabNode
{
    public string Url;
    public ClosedTabNode Next;

    public ClosedTabNode(string url)
    {
        Url = url;
        Next = null;
    }
}
