using System;

public class TimeZoneDisplay
{
    //Method to display time for a given time zone
    static void DisplayTime(string zoneName, TimeZoneInfo timeZone)
    {
        DateTimeOffset currentUtcTime = DateTimeOffset.UtcNow;
        //convert UTC time to given time zone
        DateTimeOffset zoneTime = TimeZoneInfo.ConvertTime(currentUtcTime, timeZone);
        Console.WriteLine(zoneName + " Time: " + zoneTime);
    }
	

    static void Main(string[] args)
    {
        //GMT time zone
        TimeZoneInfo gmt = TimeZoneInfo.Utc;

        //IST time zone
        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");

        //PST time zone
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        
        DisplayTime("GMT", gmt);
        DisplayTime("IST", ist);
        DisplayTime("PST", pst);
    }
}
