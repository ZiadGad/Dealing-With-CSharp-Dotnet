namespace Enums;

class Program
{
    public enum Gender
    {
        Male = 3,
        Female
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please Select an Option: ");
            Console.WriteLine("[1] Change background color \t\t[2] Change foreground color");
            string selectedOption = Console.ReadLine();

            foreach (var item in Enum.GetNames(typeof(ConsoleColor)))
                Console.Write($"{item}\t");
            Console.WriteLine("Please write color name: ");
            string colorName = Console.ReadLine();

            ConsoleColor selectedColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName, true); // true is for ignoreCase 

            if (selectedOption == "1")
            {
                Console.BackgroundColor = selectedColor;
            }else if (selectedOption == "2")
            {
                Console.ForegroundColor = selectedColor;
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }
        }
    }
}