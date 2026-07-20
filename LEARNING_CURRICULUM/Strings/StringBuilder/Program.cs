using System;
using System.Text;

void StringBuilder()
{
    /*
        A string is used to store text. When you change a string, C# creates a new string because strings cannot be changed after they are created.

        A StringBuilder is used when you are building or changing text repeatedly. It allows you to modify the same text more efficiently instead of creating a new string each time.

        The difference: string is better for text that does not change often, while StringBuilder is better for text that changes or grows many times.

        The preferred choice: Use string by default. Use StringBuilder when you are repeatedly adding, removing, or changing a large amount of text.
    */
    StringBuilder builder = new StringBuilder();

    builder.Append("Hey");
    builder.Append("How are you?");
    builder.Append("today");

    Console.WriteLine(builder);

    string message = "";
    message += "Good ";
    message += "afternoon, ";
    message += "everyone";

    Console.WriteLine(message);

    StringBuilder result = new StringBuilder();

    for (int i = 1; i <= 50; i++)
    {
        result.Append(i);
        Console.WriteLine(result);
    }

    string result1 = "";
    for (int j = 1; j <= 50; j++)
    {
        result1 += j;
        Console.WriteLine(result1);
    }

}

StringBuilder();