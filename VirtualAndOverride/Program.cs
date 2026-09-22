namespace VirtualAndOverride;

class Program
{
    static void Main(string[] args)
    {
        Animal dog = new Dog();
        dog.MakeSound();
        
        Animal cat = new Cat();
        cat.MakeSound();
        
        Animal chicken = new Chicken(); // Didn't override the base class function.
        chicken.MakeSound();
    }
}