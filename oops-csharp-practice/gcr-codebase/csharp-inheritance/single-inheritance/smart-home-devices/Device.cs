using System;

class Device
{
    public int DeviceId;
    public string Status;

    public Device(int deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }

    //Method to display device status
    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device Id: " + DeviceId);
        Console.WriteLine("Status: " + Status);
    }
}
