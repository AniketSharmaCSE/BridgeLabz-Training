using System;

public class ClosedTabStack
{
    private ClosedTabNode top;

    public ClosedTabStack()
    {
        top = null;
    }

    //Push closed tab
    public void Push(string url)
    {
        ClosedTabNode node = new ClosedTabNode(url);
        node.Next = top;
        top = node;
    }

    //Pop last closed tab
    public string Pop()
    {
        if (top == null)
        {
            return null;
        }

        string url = top.Url;
        top = top.Next;
        return url;
    }

    public bool IsEmpty()
    {
        return top == null;
    }
}
