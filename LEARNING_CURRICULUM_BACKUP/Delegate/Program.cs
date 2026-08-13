using System;
using System.Net;

class Delegate
{
    delegate void MyDelegate();
    static void CookRice()
    {
        Console.WriteLine("I am cooking rice!");
    }

    static void CookBeans()
    {
        Console.WriteLine("I am making beans.");
    }

    static void MakeVegetable()
    {
        Console.WriteLine("I am preparing vegetable soup");
    }

    static void DoSomething(MyDelegate action)
    {
        action();
    }
    
    static void Main(string[] args)
    {
        DoSomething(CookRice);
    }
}

