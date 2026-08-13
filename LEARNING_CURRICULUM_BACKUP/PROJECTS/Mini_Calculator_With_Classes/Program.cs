using System;
using System.Collections.Generic;

Run();

void ShowMenu()
{
    Dictionary<int, string> menuList = new Dictionary<int, string>
    {
        {1, "Addition"},
        {2, "Multiplication"},
        {3, "Division"},
        {0, "Exit"}
    };

    Console.WriteLine("===== CALCULATOR =====");

    foreach (KeyValuePair<int, string> list in menuList)
    {
        Console.WriteLine($"{list.Key}. {list.Value}");
    }

    Console.WriteLine();
}

void Run()
{
    int option;

    do
    {
        Console.Clear();
        ShowMenu();

        option = GetChoice();
        HandleChoice(option);

    } while (option != 0);
}

int GetChoice()
{
    while (true)
    {
        Console.Write("Choose an option: ");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine();
            return choice;
        }

        Console.WriteLine("Input must be a number.");
    }
}

void HandleChoice(int choiceInput)
{
    Calculator calc = new Calculator();
    switch (choiceInput)
    {
        case 1:
            AddInputs();
            break;

        case 2:
            MultiplyInputs();
            break;

        case 3:
            DivideInputs();
            calc.Divide();
            break;

        case 0:
            Console.WriteLine("Exiting...");
            break;

        default:
            Console.WriteLine("Invalid entry.");
            break;
    }

    if (choiceInput != 0)
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}

Calculator GetInputs()
{
    Console.Write("Enter first number: ");

    if (!decimal.TryParse(Console.ReadLine(), out decimal first))
    {
        Console.WriteLine("Invalid first number.");
        return null;
    }

    Console.Write("Enter second number: ");

    if (!decimal.TryParse(Console.ReadLine(), out decimal second))
    {
        Console.WriteLine("Invalid second number.");
        return null;
    }

    Calculator calculator = new Calculator(first, second);

    // return new Calculator(first, second);
    return calculator;
}

void AddInputs()
{
    Calculator calc = GetInputs();

    if (calc == null)
    {
        return;
    } else
    {
        Console.WriteLine($"Answer = {calc.Add()}");
    }
}

void MultiplyInputs()
{
    Calculator calc = GetInputs();

    // if (calc == null)
    //     return;

    Console.WriteLine($"Answer = {calc.Multiply()}");
}

void DivideInputs()
{
    Calculator calc = GetInputs();

    if (calc == null)
        return;

    if (calc.Num2 == 0)
    {
        Console.WriteLine("Cannot divide by zero.");
        return;
    }

    Console.WriteLine($"Answer = {calc.Divide()}");
}

class Calculator(decimal num1, decimal num2)
{
    public decimal Num1 = num1;
    public decimal Num2 = num2;

    public decimal Add()
    {
        return Num1 + Num2;
    }

    public decimal Multiply()
    {
        return Num1 * Num2;
    }

    public decimal Divide()
    {
        return Num1 / Num2;
    }
}