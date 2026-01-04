using System;

class Thermostat : Device
{
    public int TemperatureSetting;

    public Thermostat(int deviceId, string status, int temperatureSetting)
        : base(deviceId, status)
    {
        TemperatureSetting = temperatureSetting;
    }


    //Override to display thermostat specific settings
    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine("Temperature Setting: " + TemperatureSetting);
    }
}
