namespace Exceptions;

class Program
{
    static void Main(string[] args)
    {
        ThrowingException.WordCounter();
        
        try
        {
            Console.WriteLine(int.Parse("test"));
            Console.WriteLine(Divide(10,2));
            Console.WriteLine(Divide(10,0));
        }
        catch (DivideByZeroException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.ToString());
            Console.ResetColor();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(ex.ToString());
            Console.ResetColor();
        }
        finally
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(DateTime.Now);
            Console.ResetColor();
        }
    }

    static double Divide(int num1, int num2)
    {
        return num1 / num2;
    }
}