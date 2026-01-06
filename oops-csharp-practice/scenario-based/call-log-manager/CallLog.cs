using System;

public class CallLog
{
    public string PhoneNumber;
    public string Message;
    public DateTime TimeStamp;


    public CallLog(string phoneNumber, string message, DateTime timeStamp)
    {
        PhoneNumber = phoneNumber;
        Message = message;
        TimeStamp = timeStamp;
    
    }


    public void DisplayLog()
    {
        Console.WriteLine(" Phone Number:"+ PhoneNumber + "Message: "+ Message + " TimeStamp:"+TimeStamp);
    }

}
