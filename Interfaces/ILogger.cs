namespace Interfaces;

public interface ILogger
{
    void Log(string text)
    {
        Console.WriteLine($"LOG:\t{DateTime.Now}: {text}");
    }
}