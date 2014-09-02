using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class QueueExtension
{
    public static void EnqueueRange<T>(this Queue<T> @this,IEnumerable<T> items)
    {
        foreach(T item in items)
        {
            @this.Enqueue(item);
        }
    }
}