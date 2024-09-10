using System;

public class Queue<T>
{
    private Node<T> head;
    private Node<T> tail;
    private int count;

    public Queue() {
        head = null;
        tail = null;
        count = 0;
    }
    public T Get() {
        if (IsEmpty())
        {
            throw new InvalidCastException("Is Empty");
        }
        T value = head.Data;
        head = head.Next;
        count--;
        if (head == null)
        {
            tail = null;
        }
        return value;
    }
    public void Push(T item)
    {
        Node<T> newNode = new Node<T>(item);
        if (IsEmpty())
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
        count++;
    }
    private bool IsEmpty()
    {
        return count == 0;
    }
}

