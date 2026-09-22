namespace AbstractClass;

class Program
{
    /**
     * Abstract class is a class that is intended to be used as a base class.
     * We can not create an object directly from it.
     * Abstract class can contain (normal methods, fields, constructors, abstract methods, virtual methods etc...)
     * child class must override the abstract functions.
     * Abstract functions must be inside an abstract class
     *
     * ***************  Different Between Abstract and Override ***************
     * Virtual:
     *      -   Parent provides an implementation but child can override it.
     *      -   Child doesn't have to override it.
     * Abstract:
     *      -   The parent doesn't provide an implementation.
     *      -   All derived classes must implement it, Except if the derived class is also an abstract class.
     */
    
    static void Main(string[] args)
    {
        Animal dog = new Dog();
        dog.MakeSound();
        
    }
}