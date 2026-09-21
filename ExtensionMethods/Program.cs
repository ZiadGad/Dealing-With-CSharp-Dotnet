namespace ExtensionMethods;

class Program
{
    static void Main(string[] args)
    {
        int percentage = -10;
        if(!percentage.isBetween(0,100))
            Console.WriteLine($"Your percentage {percentage}% must be between 0 and 100");
        Console.WriteLine("Enter a text value");
        string input = Console.ReadLine();
        Console.WriteLine(input.RemoveWhiteSpace().Reverse());
    }
}