namespace VirtualAndOverride;

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"Mew Mew!");
    }
}