namespace AbstractClass;

public abstract class Animal
{
    public string Name { get; set; }
    public void eat()
    {
        Console.WriteLine("Eating...");
    }
    public abstract void MakeSound(); // no methods body
}