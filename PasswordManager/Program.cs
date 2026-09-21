using System.Text;

namespace PasswordManager;

class Program
{
    /**
     * 1. List all passwords
     * 2. Add or  change password
     * 3. Get password
     * 4. Delete Password
     */
    private static readonly Dictionary<string, string> _passwordEntries = new();

    static void Main(string[] args)
    {
        if (!ReadPasswords())
        {
            Console.WriteLine("Invalid master key. Exiting...");
            return;
        }


        while (true)
        {
            Console.WriteLine("Please Select an option");
            Console.WriteLine("1. List All Passwords\t2. Add/Change Password\t3. Get Password\t 4. Delete Password");

            var selectedOption = Console.ReadLine();
            switch (selectedOption)
            {
                case "1":
                    ListAllPasswords();
                    break;
                case "2":
                    AddOrChangePassword();
                    break;
                case "3":
                    GetPassword();
                    break;
                case "4":
                    DeletePassword();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

            Console.WriteLine("==============================================");
        }
    }

    private static bool ReadPasswords()
    {
        if (File.Exists("passwords.txt"))
        {
            var passwordLines = File.ReadAllText("passwords.txt");
            Console.WriteLine("Enter your master key");
            var masterKey = Console.ReadLine();
            foreach (var line in passwordLines.Split(Environment.NewLine))
            {
                if (!string.IsNullOrEmpty(line))
                {
                    //  Check the master key
                    
 
                    //website=password
                    var equalsIndex = line.IndexOf("=");
                    var appName = line.Substring(0, equalsIndex);
                    var password = line.Substring(equalsIndex + 1);
                    _passwordEntries.Add(appName, EncryptionUtility.Decrypt(password));
                    
                    if (!_passwordEntries.ContainsKey("masterKey") || _passwordEntries["masterKey"] != masterKey)
                    {
                        Console.WriteLine($"Your password is Decrypted as {EncryptionUtility.Decrypt(masterKey)}");
                        return false;
                    }
                    
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter your master key");
            string masterKey = Console.ReadLine();
            _passwordEntries.Add("masterKey", masterKey);
        }

        return true;
    }

    private static void savePasswords()
    {
        var sb = new StringBuilder();
        foreach (var entry in _passwordEntries)
            sb.AppendLine($"{entry.Key}={EncryptionUtility.Encrypt(entry.Value)}");
        File.WriteAllText("passwords.txt", sb.ToString());
    }

    private static void DeletePassword()
    {
        Console.WriteLine($"Please enter your website/app name");
        var appName = Console.ReadLine();
        if (_passwordEntries.ContainsKey(appName))
        {
            _passwordEntries.Remove(appName);
            savePasswords();
        }
        else
            Console.WriteLine($"Password not found");
    }

    private static void GetPassword()
    {
        Console.WriteLine($"Please enter your website/app name");
        var appName = Console.ReadLine();
        if (_passwordEntries.ContainsKey(appName))
            Console.WriteLine($"Your password is {_passwordEntries[appName]}");
        else
            Console.WriteLine($"Password not found");
    }

    private static void AddOrChangePassword()
    {
        Console.WriteLine($"Please enter the website/app name");
        string appName = Console.ReadLine();
        Console.WriteLine($"Please enter the password");
        string password = Console.ReadLine();

        if (_passwordEntries.ContainsKey(appName))
        {
            _passwordEntries[appName] = password;
            savePasswords();
        }
        else
        {
            _passwordEntries.Add(appName, password);
            savePasswords();
        }
    }

    private static void ListAllPasswords()
    {
        foreach (var password in _passwordEntries)
            Console.WriteLine($"{password.Key}={password.Value}");
    }
}