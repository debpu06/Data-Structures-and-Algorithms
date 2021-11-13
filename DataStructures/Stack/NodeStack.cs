using System;

namespace Structures.Stack
{
    public class NodeStack<T> : IStack<T>
    {
        private StackNode top;
        private int size = 0;

        public int Size => size;

        //O(1)
        public bool IsEmpty(){
            return top == null;
        }

        //O(1)
        public void Push(T element){
            StackNode node = new StackNode(element, top);
            top = node;
            size++;
        }

        //O(1)
        public T Pop(){
            if(IsEmpty())
                throw new Exception("Stack Underflow");
            else    
            {
                var temp = top.Element;
                top = (StackNode)top.Next;
                size--;

                return temp;
            }
        }

        private class StackNode : Node<T>
        {
            public StackNode(T element, StackNode next) : base(element){
                this.Next = next;
            }
        }
    }
}