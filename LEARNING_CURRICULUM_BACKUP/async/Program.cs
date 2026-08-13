using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Start");

        await DoSomethingAsync();

        Console.WriteLine("Finished");
    }

    static async Task DoSomethingAsync()
    {
        await Task.Delay(3000);

        Console.WriteLine("Work finished!");
    }
}