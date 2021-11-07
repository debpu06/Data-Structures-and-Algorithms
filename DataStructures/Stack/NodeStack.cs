using System;

public class NodeStack<T> : IStack<T>
{
    private Node top;
    private int size = 0;

    public int Size => size;

    //O(1)
    public bool IsEmpty(){
        return top == null;
    }

    //O(1)
    public void Push(T element){
        Node node = new Node(element, top);
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
            top = top.Next;
            size--;

            return temp;
        }
    }

    private class Node
    {
        public Node(T element, Node next){
            this.Element = element;
            this.Next = next;
        }
        public T Element { get;set; }
        public Node Next { get;set; }
    }
}