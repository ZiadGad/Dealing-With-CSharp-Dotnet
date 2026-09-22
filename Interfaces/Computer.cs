namespace Interfaces;

public class Computer : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Computer turning on");
    }

    public void TurnOff()
    {
        Console.WriteLine("Computer turning off");
    }
}