using System;

public class Stack <T> : IStack<T>
{
    private int top = 0;
    private int size;

    private T[] stack;

    public Stack(int size = 10){
        this.size = size;
        stack = new T[size];
    }

    //O(1)
    public bool IsEmpty(){
        if(top == 0)
            return true;
        else
            return false;
    }

    //O(1)
    public void Push(T element){
        top++;
        if(top > size)
            throw new Exception("Stack Overflow");
        stack[top] = element;
    }

    //O(1)
    public T Pop(){
        if(IsEmpty())
            throw new Exception("Stack Underflow");
        else
        {
            top--;
            return stack[top + 1];
        }
    }
}