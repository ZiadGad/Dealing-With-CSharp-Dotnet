namespace Interfaces;

class Program
{
    /**
     * Interface: Defines what class must be able to do.
     * Class can inherit multiple interfaces at the same time.
     * Implicit and Explicit Implementation:
     *      -   Implementing the Interface methods in normal way called implicit.
     *          But what if your class inherits more than one interface and all of them have the same name function Speak()?
     *      -   If you need to use the function of a specific Interface this called (Explicit conversion).
     *          You have to Implement the function with the interface name like IEnglishSpeaker.Speak() or IArabicSpeaker.Speak().
     *          The variable must be an Interface type to choose wich method to call, you can not make it a class type.
     * Default Implementation is when defining a body of function inside the interface itself, and the calss can override it.
     */
    static void Main(string[] args)
    {
        //  Dealing with Interface Section
        IDevice computer = new Computer();
        computer.TurnOn();
        computer.TurnOff();

        IDevice mobile = new MobilePhone();
        mobile.TurnOn();
        mobile.TurnOff();
        
        // Implicit and Explicit Implementation Section
        IEnglishSpeaker ziad = new Person();
        ziad.Speak();

        IArabicSpeaker ali = new Person();
        ali.Speak();
        
        // Person person = new Person(); 
        // person.Speak() //! Error
        
        // Default Implementation Section
        ILogger logger = new FileLogger();
        logger.Log("FileLogger Message");

        logger = new ConsoleLogger();
        logger.Log("consoleLogger Message");
        
        FileLogger fileLogger = new FileLogger();
        // filelogger.Log("FileLogger Message"); // Error: the default implementation belongs to the interface itself.

    }
}