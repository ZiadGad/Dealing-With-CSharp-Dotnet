using System.Collections;

namespace StackAndQueue;

class Program
{
    /**
     * Stacks and Queues has generic and non-generic versions, Always use the generics if you don't need the loosely type.
     * Stack Uses: LIFO
     * Queues Uses: FIFO
     */
    static void Main(string[] args)
    {
        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Pop();
        Console.WriteLine(stack.Peek()); // Peek returns the last value without deleting it.
        Console.WriteLine("*******************");
        PrintStack(stack);
        Console.WriteLine("====================");

        //  ***************************
        // QUEUES
        var queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        PrintQueue(queue);
        Console.WriteLine("*******************");
        queue.Dequeue();
        PrintQueue(queue);
    }

    static void PrintStack(Stack<int> stack)
    {
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }
    }

    static void PrintQueue(Queue<int> queue)
    {
        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }
    }
}