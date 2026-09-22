namespace VirtualAndOverride;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.MakeSound();
        
        Cat cat = new Cat();
        cat.MakeSound();
        
        Chicken chicken = new Chicken(); // Didn't override the base class function.
        chicken.MakeSound();
    }
}