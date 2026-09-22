namespace VirtualAndOverride;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine($"Some sound");
    }
}