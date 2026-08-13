using System;

static void PromptUser()
{
    if (int.TryParse(Console.ReadLine(), out int input)) Console.WriteLine($"{input + 1}");
}

PromptUser();