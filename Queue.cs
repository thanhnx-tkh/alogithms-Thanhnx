using System;
using System.Collections.Generic;

public class Queue<T>
{
    private List<T> list = new List<T>();

    public T Get()
    {
        T temp =  list[0];
        list.RemoveAt(0);
        return temp;
    }
    public void Push(T t)
    {
        list.Add(t);
    }
}

