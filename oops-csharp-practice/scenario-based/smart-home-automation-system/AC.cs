public class AC : Appliance
{
    public AC(string name) : base(name)
    {
    }

    public override void TurnOn()
    {
        if (!isOn)
        {
            isOn = true;
            Console.WriteLine("AC turned on");
        }
        else
        {
            Console.WriteLine("AC is already on");
        }
    }

    public override void TurnOff()
    {
        if (isOn)
        {
            isOn = false;
            Console.WriteLine("AC turned off");
        }
        else
        {
            Console.WriteLine("AC is already off");
        }
    }
}
