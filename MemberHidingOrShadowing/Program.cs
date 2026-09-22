namespace MemberHidingOrShadowing;

class Program
{
    /**
     * used when we can't access  the base class to change its function to be virtual, and you need to override the parent class
     * if you just named a child method the same name of parent methods you will get warning from the compiler, avoid it by using the new keyword
     */
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.MakeSound(); // this is not using the member hiding because the variable type is a Dog so it uses the Dog methods
        
        Animal animal = new Dog();
        animal.MakeSound();
    }
}