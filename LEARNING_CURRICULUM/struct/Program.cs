using System;

Testing test = new Testing();
test.Name = "Dara";
Console.WriteLine($"test before: {test.Name}");

Testing test2 = test;
test2.Name = "Simi";
Console.WriteLine($"test after : {test.Name}");
Console.WriteLine($"test2: {test2.Name}");
struct Testing
{
    public string? Name;
}