using System;


namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func(2);
        }
        
        static void Func(int num)
        {
            int data = num + num;
            Console.WriteLine(data);
        }
    };
}