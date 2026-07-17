using System;

class Nullable
{
    static void Main(string[] args)
    {
        static void nullableType()
{
    int? children = null;
    Console.WriteLine(children);
    children = 5;
    Console.WriteLine(children);


    string? phone = null;
    Console.WriteLine(phone ?? "No phone number.");
}
    nullableType();
    }
}

