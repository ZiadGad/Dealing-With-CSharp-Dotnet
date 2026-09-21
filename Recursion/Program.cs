namespace Recursion;

class Program
{
    static void Main(string[] args)
    {
        // int f = CalculateFactorial(5);
        // Console.WriteLine(f);

        PrintDirectoryFileSystemEntries(@"/Desktop/c#-fundamentals/DealingWithCSharp/Recursion");
        var size = CalculateDirectorySize(@"/Desktop/c#-fundamentals/DealingWithCSharp/Recursion");
        Console.WriteLine($"Direcotry Size: {size / 1024} KB");
    }

    public static long CalculateDirectorySize(string dirPath)
    {
        long size = 0;
        foreach (var fileName in Directory.GetFiles(dirPath))
            size += new FileInfo(fileName).Length;
        foreach (var dirName in Directory.GetDirectories(dirPath))
            size += CalculateDirectorySize(dirName);
        return size;
    }

    public static void PrintDirectoryFileSystemEntries(string dirPath, int level = 1)
    {
        foreach (var fileName in Directory.GetFiles(dirPath))
            Console.WriteLine($"{new string('_', level)}{new FileInfo(fileName).Name}");
        foreach (var dirName in Directory.GetDirectories(dirPath))
        {
            Console.WriteLine($"{new string('_', level)}{new DirectoryInfo(dirName).Name}");
            PrintDirectoryFileSystemEntries(dirName, level + 1);
        }
    }

    public static int CalculateFactorial(int n)
    {
        if (n <= 1)
            return n;
        return n * CalculateFactorial(n - 1);
    }
}