/*
    A generic class is simply a class that can work with different data types withoutbeing rewritten.

    Instead of writing one class for int, another for string, and another for Product, you write one class that works for all of them.
*/

using System.Net.Http.Headers;
using System;
class Box<T>
{
    public T? Value { get; set; }
}

class Pro
{
    static void Main(string[] args)
    {
        Box<int> intBox = new Box<int>();
        intBox.Value = 10;

        Box<string> stringBox = new Box<string>();
        stringBox.Value = "Hello";

        Console.WriteLine(intBox.Value);
        Console.WriteLine(stringBox.Value);

    }
}
