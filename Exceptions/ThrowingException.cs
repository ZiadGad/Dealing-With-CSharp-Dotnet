namespace Exceptions;

public class ThrowingException
{
        public static void WordCounter()
        {
                Console.Write("Please enter only 5 numbers: ");
                string word = Console.ReadLine();
                if (word.Length != 5)
                {
                        Console.ForegroundColor = ConsoleColor.Red;
                        throw new Exception("String must be 5 characters long");
                }
        }
}
