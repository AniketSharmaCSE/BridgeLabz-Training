using System;

class SmartHome
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter device id:");
        int deviceId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter device status:");
        string status = Console.ReadLine();
        Console.WriteLine("Enter temperature setting:");
        int temperature = Convert.ToInt32(Console.ReadLine());

        Device device = new Thermostat(deviceId, status, temperature);

        Console.WriteLine("Device Status:");
        device.DisplayStatus();
    }
}
