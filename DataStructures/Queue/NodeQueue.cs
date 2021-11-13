using System;
namespace DataStructures.Queue
{
    public class NodeQueue<T>
    {
        private QueueNode head;
        private QueueNode tail;

        public void Enqueue(T element)
        {
            var temp = new QueueNode(element); 
            
            if(head == null)
                head = tail = temp;
            else
            {
                tail.Next = temp;
                tail = temp;
            }
        }

        public T Dequeue()
        {
            if(head == null)
                throw new Exception("Queue Empty");

            var temp = head.Element;
            head = (QueueNode)head.Next;

            return temp;
        }
    
        private class QueueNode : Node<T>
        {
            public QueueNode(T element) : base(element){

            }
        }
    }
}