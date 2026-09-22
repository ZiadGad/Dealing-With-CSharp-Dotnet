namespace Interfaces;

public class ConsoleLogger: ILogger
{
    public void Log(string text)
    {
        Console.WriteLine($"Custom:\t{text}");
    }
}