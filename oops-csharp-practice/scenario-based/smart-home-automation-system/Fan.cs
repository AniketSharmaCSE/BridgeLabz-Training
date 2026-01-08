public class Fan : Appliance
{
    public Fan(string name) : base(name)
    {
    }

    public override void TurnOn()
    {
        if (!isOn)
        {
            isOn = true;
            Console.WriteLine("Fan turned on");
        }
        else
        {
            Console.WriteLine("Fan is already on");
        }
    }

    public override void TurnOff()
    {
        if (isOn)
        {
            isOn = false;
            Console.WriteLine("Fan turned off");
        }
        else
        {
            Console.WriteLine("Fan is already off");
        }
    }
}
