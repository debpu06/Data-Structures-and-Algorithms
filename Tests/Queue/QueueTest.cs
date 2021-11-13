using System;
using DataStructures.Queue;

public class QueueTest : ITest
{
    void ITest.Run()
    {
        var queue = new NodeQueue<string>();

        Console.WriteLine("Queue \"Item 1\", \"Item 2\", \"Item 3\"");
        queue.Enqueue("Item 1");
        queue.Enqueue("Item 2");
        queue.Enqueue("Item 3");

        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());
    }
}