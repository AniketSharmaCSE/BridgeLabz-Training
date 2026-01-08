public class Light : Appliance
{
    public Light(string name) : base(name)
    {
    }

    public override void TurnOn()
    {
        if (!isOn)
        {
            isOn = true;
            Console.WriteLine("Light turned on");
        }
        else
        {
            Console.WriteLine("Light is already on");
        }
    }

    public override void TurnOff()
    {
        if (isOn)
        {
            isOn = false;
            Console.WriteLine("Light turned off");
        }
        else
        {
            Console.WriteLine("Light is already off");
        }
    }
}
