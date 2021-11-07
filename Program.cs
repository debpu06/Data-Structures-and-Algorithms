using System;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            var testStack = new Stack<string>();
            var testNodeStack = new NodeStack<string>();

            testStack.Push("Item 1");
            testStack.Push("Item 2");
            testStack.Push("Item 3");

            Console.WriteLine("Test Stack (Push \"Item 1\", \"Item 2\", \"Item 3\")");
            Console.WriteLine(testStack.Pop());
            Console.WriteLine(testStack.Pop());
            Console.WriteLine(testStack.Pop());

            testNodeStack.Push("Item 1");
            testNodeStack.Push("Item 2");
            testNodeStack.Push("Item 3");

            Console.WriteLine("Test Node Stack (Push \"Item 1\", \"Item 2\", \"Item 3\")");
            Console.WriteLine(testNodeStack.Pop());
            Console.WriteLine(testNodeStack.Pop());
            Console.WriteLine(testNodeStack.Pop());
        }
    }
}
