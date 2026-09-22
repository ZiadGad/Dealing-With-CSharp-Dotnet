namespace ArrayList;

using System.Collections;

class Program
{
    /**
     * loosely typed.
     * dynamic.
     * evertything in c# is an object.
     * when loop over an arraylist we must make the iteration variable type (object/var) because of the different values.
     *
     * ArrayList uses Boxing and Unboxing to convert the value types to a reference types.
     */
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add("ziad");
        list.Add(23);
        list.Add(true);
        PrintArray(list);
        list.Remove(23);
        PrintArray(list);
        list.RemoveAt(0);
        PrintArray(list);
    }

    static void PrintArray(ArrayList list)
    {
        foreach (object o in list)
            Console.WriteLine(o);
        Console.WriteLine("*********************");
    }
}