using System;

class Loop
{
    static void Main()
    {
        int num = 5;

        // while (num <= 5)
        // {
        //     Console.WriteLine(num);
        //     num++;
        // }

        do
        {
            Console.WriteLine($"This will print as long as {num} is lesser than or equals 10.");
            num++;
        } while (num <= 10);
        }

    
}

