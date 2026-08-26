namespace RefAndOutKeywords;

public class Program
{
    static void Main(string[] args)
    {
        TestValue();
        TestRef();
        TestOut();
    }


    public static void TestValue()
    {
        bool isSuccessful = true;
        var resault = Divide(10, 0, isSuccessful);
        Console.WriteLine($"isSuccessful = {isSuccessful}");
        Console.WriteLine($"resault = {resault}");
    }

    /// <remarks>
    /// ref parameter MUST be initialized before use.
    /// bool isSuccessful; Error!!
    /// </remarks>
    public static void TestRef()
    {
        bool isSuccessful = true;
        var resault = DivideRef(10, 0, ref isSuccessful);
        Console.WriteLine($"isSuccessful = {isSuccessful}");
        Console.WriteLine($"resault = {resault}");
    }

    /// <remarks>
    /// The out parameter doesn't need to be initialized before use.
    /// However, you must assign a value to it before returning from the method.
    /// </remarks>
    public static void TestOut()
    {
        bool isSuccessful;
        var resault = DivideOut(10, 0, out isSuccessful);
        Console.WriteLine($"isSuccessful = {isSuccessful}");
        Console.WriteLine($"resault = {resault}");
    }

    static double DivideOut(double number, double divisor, out bool isSuccessful)
    {
        if (divisor == 0)
        {
            Console.WriteLine($"Cannot divide by zero!");
            isSuccessful = false; // if you don't assign a value, you will get an error.
            return 0;
        }

        isSuccessful = true;      // if you don't assign a value you will get an error.
        return number / divisor;
    }

    public static double DivideRef(double number, double divisor, ref bool isSuccessful)
    {
        if (divisor == 0)
        {
            Console.WriteLine($"Cannot divide by zero!");
            isSuccessful = false;
            return 0;
        }

        isSuccessful = true;
        return number / divisor;
    }

    static double Divide(double number, double divisor, bool isSuccessful)
    {
        if (divisor == 0)
        {
            Console.WriteLine($"Cannot divide by zero!");
            isSuccessful = false;
            return 0;
        }

        isSuccessful = true;
        return number / divisor;
    }
}