using System;
class BankInterestCalculator
{

    static string? customerName;
    static int principalAmount;
    static bool isNumeric;
    static void ShowMenu()
    {
        Console.WriteLine("=========WELCOME TO BANK INTEREST CALCULATOR========");

        do
        {
            Console.Write("Enter your name: ");
            customerName = Console.ReadLine()!;

            if (string.IsNullOrWhiteSpace(customerName))
            {
                Console.WriteLine("Customer name cannot be empty.");
            }

        } while (string.IsNullOrWhiteSpace(customerName));
        Console.WriteLine($"Welcome, {customerName}!");


        do
        {
            Console.Write("Enter principal amount: ");
            isNumeric = int.TryParse(Console.ReadLine(), out principalAmount);
            if (!isNumeric)
            {
                Console.WriteLine("Principal amount must be numeric.");
                // Console.WriteLine(principalAmount);
            }
        } while (!isNumeric);


         Console.Write("\n");

    }


    static void InvestmentSummary()
    {
        Console.WriteLine("========INVESTMENT SUMMARY========");
        string[] summary =
        {
            $"Customer Name: {customerName}",
            $"Principal Amount: {principalAmount}",
        };

        foreach(string item in summary)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Thank you for using Bank Interest Calculator.\n");
    }


    static void Main(string[] args)
    {
        int choice;

        do
        {
            ShowMenu();
            InvestmentSummary();
            entry:
            Console.WriteLine("Do you want to calculate another investment?");
            Console.WriteLine("1 - Yes.");
            Console.WriteLine("2 - No, Exit.");

            // string options = @"
            // 1 - Yes
            // 2 - No
            // ";

            // Console.Write(options);

            isNumeric = int.TryParse(Console.ReadLine(), out choice);
            if (!isNumeric)
            {
                Console.WriteLine("Option must be numeric. Kindly type 1 or 2.");
                goto entry;
            }
             if (choice != 1 && choice != 2)
            {
                System.Console.WriteLine($"Result: {choice}");
                Console.WriteLine("Invalid option, select 1 or 2.");
                // choice = 0;
                goto entry;
            }

        } while (choice != 2);
        Console.WriteLine("Alright, see ya later!");
    }
}