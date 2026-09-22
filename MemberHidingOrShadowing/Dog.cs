namespace MemberHidingOrShadowing;

public class Dog : Animal
{
    public new void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }
}