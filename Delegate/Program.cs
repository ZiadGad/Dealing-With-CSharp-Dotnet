namespace Delegate;

class Program
{
    delegate void Greeting(string name);

    delegate void MessageHandler(string msg);

    static void Main(string[] args)
    {
        Greeting greeting = SayHello;
        greeting("ziad");
        
        //*****************************************
        //  Passing method to another method
        Console.WriteLine($"*************\tPassing method to another method\t*************");
        ProcessMessage("ziad", SayHello);
        ProcessMessage("ziad", SayGoodbye);

        //*****************************************
        // Anonymous Function
        Console.WriteLine($"*************\tAnonymous Function\t*************");
        MessageHandler handler = delegate(string name) { Console.WriteLine("Hello " + name); };
        handler("ziad");
        
        //*****************************************
        Console.WriteLine($"*************\tLambda expressions\t*************");
        handler = (name) => Console.WriteLine("Hello " + name);
        handler("ziad");
    }

    static void SayHello(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    static void SayGoodbye(string name)
    {
        Console.WriteLine("Goodbye " + name);
    }

    static void ProcessMessage(string name, MessageHandler handler)
    {
        handler(name);
    }
}