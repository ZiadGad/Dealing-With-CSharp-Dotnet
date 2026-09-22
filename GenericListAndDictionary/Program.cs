namespace GenericListAndDictionary;

class Program
{
    /**
     * Generic List is the generic equivalent for the ArrayList
     * Generic List solves the boxing and unboxing problem, because it's a strong typed.
     * Strong Typed like Array
     * Dynamic like ArrayList
     * Same Array and ArrayList built-in functions.
     *
     * Dictionary
     */
    static void Main(string[] args)
    {
        //  Generic List
        var list = new List<int>();
        list.Add(1);
        list.Add(2);
        // list.Add("ziad"); // Error: Argument type 'string' is not assignable to parameter type 'int'
        
        // Dictionary
        var emails = new Dictionary<string, string>();
        emails.Add("gmail","ziadamrjad@gmail.com");
        emails.Add("icloud","ziiadamrjad@icloud.com");
        
        if(!emails.ContainsKey("icloud"))
            emails.Add("icloud","ziiadamrjad@icloud.com");
        
        //Console.WriteLine(emails["hotmail"]); // Error Crashes: The given key 'hotmail' was not present in the dictionary.
        
        if(emails.ContainsKey("hotmail")) // Safely Print
            Console.WriteLine(emails["hotmail"]);
        
        if(emails.TryGetValue("hotmail", out string value)) // Another Safely Print
            Console.WriteLine(value);

        
    }
}