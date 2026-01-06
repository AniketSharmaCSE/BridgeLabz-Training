using System;

public class CallLogManager
{
    CallLog[] logs;
    int index = 0;

   
    public CallLogManager(int size)
    {
        logs = new CallLog[size];
    }


    //Adds a call log if space is available
    public void AddCallLog(CallLog log)
    {
        if (index >= logs.Length)
        {
            Console.WriteLine("Log directory is full");
            return;
        }

        logs[index] = log;
        index++;
        Console.WriteLine("Log added successfully");
    }


    //Search logs by keyword in message
    public void SearchByKeyword(string keyword)
    {
        
        bool found = false;

        for (int i = 0; i < index; i++)
        {
            if (logs[i].Message.Contains(keyword))
            {
                logs[i].DisplayLog();
                found = true;
            }
        }


        if (!found)
        {
            Console.WriteLine("No logs found for given keyword");
        }
    
    }

    
    //Filter logs within time range
    public void FilterByTime(DateTime start, DateTime end)
    {
        bool found = false;
        for (int i = 0; i < index; i++)
        {
            if (logs[i].TimeStamp >= start && logs[i].TimeStamp <= end)
            {
                logs[i].DisplayLog();
                found = true;
            }
    
        }

        if (!found)
        {
            Console.WriteLine("No logs found in given time range");
        
        }

    }

}


