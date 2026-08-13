using System;
class MethodOverloading
{
    // Method overloading allows us to use the same method names for methods that perform the same logical action, but require different parameters.
    static string Greet()
    {
        return "Hello, welcome to method overloading!";
    }

    static string Greet(string name)
    {
        return $"Hello, {name}";
    }

    static string Greet(long number, string naming)
    {
        return $"Welcome {naming}, your phone number is {number}";
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Greet());
        Console.WriteLine(Greet("Darasimi"));
        Console.WriteLine(Greet(naming: "Oluwabukola", number: 08107649820)); //Named arguments.
    }
}