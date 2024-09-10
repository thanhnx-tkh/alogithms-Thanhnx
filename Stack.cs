using System;

public class Stack<T>
{
    private Node<T> top;
    private int count;

    public Stack()
    {
        top = null;
        count = 0;
    }
    public T Get()
    {
        if (IsEmpty())
        {
            throw new InvalidCastException("Is Empty");
        }
        T value = top.Data;
        top = top.Next;
        count--;
        return value;
    }
    public void Push(T item)
    {
        Node<T> newNode = new Node<T>(item);
        newNode.Next = top;
        top = newNode;
        count++;
    }
    private bool IsEmpty()
    {
        return count == 0;
    }
}

