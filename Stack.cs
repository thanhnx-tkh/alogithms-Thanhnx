using System;
using System.Collections.Generic;

public class Stack<T>
{
    private List<T> list = new List<T>();

    public T Get()
    {
        T temp = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        return temp;
    }
    public void Push(T t)
    {
        list.Add(t);
    }
}

