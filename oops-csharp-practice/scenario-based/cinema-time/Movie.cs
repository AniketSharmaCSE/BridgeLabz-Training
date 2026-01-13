using System;

public class Movie
{
    public string Title;
    public string[] ShowTimes;
    public int ShowTimeCount;

    public Movie(string title)
    {
        Title = title;
        ShowTimes = new string[100];
        ShowTimeCount = 0;
    }

    //Method to add showtime
    public void AddShowTime(string time)
    {
        if (!IsValidTime(time))
        {
            Console.WriteLine("Invalid time format. Use HH:MM");
            return;
        }

        if (ShowTimeCount < ShowTimes.Length)
        {
            ShowTimes[ShowTimeCount] = time;
            ShowTimeCount++;
        }
    }

    //Method to validate showtime format
    private bool IsValidTime(string time)
    {
        if (time.Length != 5)
        {
            return false;
        }

        if (time[2] != ':')
        {
            return false;
        }
        return true;
    }
}
