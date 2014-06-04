using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class ArrayExtension
{
    /// <summary>
    /// Same to Array.ForEach(array,action)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="array"></param>
    /// <param name="action"></param>
    public static void ForEach<T>(this T[] array,Action<T> action)
    {
        Array.ForEach(array,action);
    }
}