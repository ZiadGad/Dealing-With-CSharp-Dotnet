namespace GenericListAndDictionary;

class Program
{
    /**
     * Generic List is the generic equivalent for the ArrayList
     * Generic List solves the boxing and unboxing problem, because it's a strong typed.
     * Strong Typed like Array
     * Dynamic like ArrayList
     * Same Array and ArrayList built-in functions.
     */
    static void Main(string[] args)
    {
        var list = new List<int>();
        list.Add(1);
        list.Add(2);
        // list.Add("ziad"); // Error: Argument type 'string' is not assignable to parameter type 'int'
        
    }
}