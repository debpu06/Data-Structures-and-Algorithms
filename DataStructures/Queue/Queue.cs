using System;

namespace DataStructures.Queue
{
    public class Queue<T>
    {

        private T[] queue;

        private int head = 0;
        private int tail = 0;
        private int size;

        public Queue(int size = 10)
        {
            this.size = size;
            queue = new T[size];
        }

        //O(1)
        public void Enqueue(T element)
        {
            if (tail > size)
                throw new Exception("Queue Overflow");

            queue[tail] = element;
            if (tail == size)
                tail = 1;
            else
                tail++;
        }

        //O(1)
        public T Dequeue()
        {
            T element = queue[head];
            if (head == size)
                head = 1;
            else
                head++;

            return element;
        }
    }
}