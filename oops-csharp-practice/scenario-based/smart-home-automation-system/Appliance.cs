public abstract class Appliance : IControllable
{
    protected string name;
    protected bool isOn;

    public Appliance(string name)
    {
        this.name = name;
        isOn = false;
    }

    public abstract void TurnOn();
    public abstract void TurnOff();
}
