namespace Interfaces;

public class MobilePhone : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Mobile turning on");
    }

    public void TurnOff()
    {
        Console.WriteLine("Mobile turning off");
    }
}