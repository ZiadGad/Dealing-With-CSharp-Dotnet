using System.Text;

namespace TrainingApp_RandomValuesGenerator;

[Flags]
public enum CharacterSets
{
    None = 0,
    UppercaseLetters = 1,
    LowercaseLetters = 2,
    Numbers = 4,
    Symbols = 8,
    All = UppercaseLetters | LowercaseLetters | Numbers | Symbols
}

class Program
{
    private const string UppercaseBuffer = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string LowercaseBuffer = "abcdefghijklmnopqrstuvwxyz";
    private const string NumberBuffer = "0123456789";
    private const string symbols = "$#@!*";

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please Select an option:");
            Console.WriteLine("[1] Generate Random Numbers\t\t[2] Generate Random Strings\t\t[0]Exit");
            string selectedOption = Console.ReadLine();
            if (selectedOption == "0") break;
            switch (selectedOption)
            {
                case "1":
                    GenerateRandomNumbers();
                    break;
                case "2":
                    RandomStringHandler();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    public static void GenerateRandomNumbers()
    {
        int min = ReadInteger("Enter the minimum value: ");
        int max = ReadInteger("Enter the maximum value: ");

        if (max < min)
        {
            Console.WriteLine("Minimum value cannot be greater than maximum value.");
            return;
        }

        int value = Random.Shared.Next(min, max + 1);
        Console.WriteLine($"Result: {value}");
    }

    public static void RandomStringHandler()
    {
        int length = ReadInteger("Enter the string length: ");
        if (length <= 0)
        {
            Console.WriteLine("Length must be greater than 0.");
            return;
        }

        CharacterSets options = CharacterSets.None;
        GenerateRandomString();
    }

    public static void GenerateRandomString()
    {
        Console.WriteLine("Custom your random string:");
        Console.WriteLine("Uppercase? yes/no");
        string uppercaseString = Console.ReadLine();
        Console.WriteLine("Lowercase? yes/no");
        string lowercaseString = Console.ReadLine();
        Console.WriteLine("Numbers? yes/no");
        string numbersString = Console.ReadLine();
        Console.WriteLine("Symbols? yes/no");
        string symbolsString = Console.ReadLine();

        if (uppercaseString.ToLower() == "yes" || uppercaseString.ToLower() == "y")
        {
            
        }

    }
    public static int ReadInteger(string prompt)
    {
        int value;
        do
        {
            Console.Write(prompt);
        } while (!int.TryParse(Console.ReadLine(), out value));

        return value;
    }
}