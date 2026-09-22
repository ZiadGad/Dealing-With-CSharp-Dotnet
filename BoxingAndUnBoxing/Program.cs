namespace BoxingAndUnBoxing;

class Program
{
    /**
     * Boxing is to cover the value type with a reference type to save it in the heap memory.
     *      - After Boxing you can't use it like how it was, you can't add to it or subtract from it.
     *      - First you have to UnBox it.
     * UnBoxing is to return it as it was.
     */
    static void Main(string[] args)
    {
        // Boxing
        int x = 5; // value type
        object y = x; // reference type
        Console.WriteLine(x); // -> 5
        Console.WriteLine(y); // -> 5

        //int z = y + x; // Error: Cannot apply operator '+' to operands of type 'object' and 'int'
        
        // UnBoxing with typecase
        int z = (int)y + x;
        Console.WriteLine(z);



    }
}