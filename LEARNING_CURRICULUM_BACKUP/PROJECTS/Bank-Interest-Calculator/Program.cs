using System;
class BankInterestCalculator
{

    static string? customerName;
    static decimal principalAmount;
    static decimal interestRate;
    static int investmentDuration;
    static decimal interestEarned;
    static decimal totalAmount;
    static bool isNumeric;


static void ShowMenu()
    {
        Console.WriteLine("=========WELCOME TO BANK INTEREST CALCULATOR========");

        CustomerName();
        PrincipalAmount();
        InterestRate();
        InvestmentDuration();
        CalculateInterest();

        Console.Write("\n");

    }
    static void CustomerName()
    {
        do
        {
            Console.Write("Enter your name: ");
            customerName = Console.ReadLine()!;

            if (string.IsNullOrWhiteSpace(customerName) || customerName.Any(character => !char.IsLetter(character)))
            {
                Console.WriteLine("Customer name cannot be empty and can onl contain alphabets.");
            }

        } while (string.IsNullOrWhiteSpace(customerName) || customerName.Any(character => !char.IsLetter(character)));
        Console.WriteLine($"Welcome, {customerName}!");
    }

    static void PrincipalAmount()
    {
        do
        {
            Console.Write("Enter principal amount: ");
            isNumeric = decimal.TryParse(Console.ReadLine(), out principalAmount);
            if (!isNumeric || principalAmount <= 0)
            {
                Console.WriteLine("Principal amount must be numeric and greater than 0.");
                // Console.WriteLine(principalAmount);
            }
        } while (!isNumeric || principalAmount <= 0);
    }
    static void InterestRate()
    {
        do
        {
            Console.Write("Enter annual interest rate (percentage): ");
            isNumeric = decimal.TryParse(Console.ReadLine(), out interestRate);
            if (!isNumeric || interestRate <= 0 || interestRate > 100)
            {
                Console.WriteLine("Interest rate must be numeric, greater than 0, and not grater than 100.");
            }
        } while (!isNumeric || interestRate <= 0 || interestRate > 100);

        // do
        // {
        //     Console.Write("Enter annual interest rate:");
        //     isNumeric = int.TryParse(Console.ReadLine(), out interestRate);
        //     if (interestRate <= 0)
        //     {
        //         Console.WriteLine("Interest rate must be greater than 0.");
        //     }
        // } while (interestRate <= 0);

    }

    static void InvestmentDuration()
    {
        do
        {
            Console.Write("Enter investment duration (in years): ");
            isNumeric = int.TryParse(Console.ReadLine(), out investmentDuration);
            if (!isNumeric || investmentDuration <= 0)
            {
                Console.WriteLine("Investment duration must be numeric and greater than 0");
            }
        } while (!isNumeric || investmentDuration <= 0);
    }

    static void CalculateInterest()
    {
        //Interest = Principal * Rate * Time / 100 ===== PEMDAS
        interestEarned = principalAmount * interestRate * investmentDuration / 100;

        //Total amount = Principal + Interest
        totalAmount = principalAmount + interestEarned;
    }

    static void InvestmentSummary()
    {
        Console.WriteLine("========INVESTMENT SUMMARY========");
        string[] summary =
        {
            $"Customer Name: {customerName}",
            $"Principal Amount: ₦{principalAmount:N2}",
            $"Annual Interest Rate: {interestRate}%",
            $"Investment Duration: {investmentDuration}years",
            $"Interest Earned: ₦{interestEarned:N2}",
            $"Total Amount (Principal + Interest): ₦{totalAmount:N2}",
            

            /*
            1583145.22N2 means:
            N → add thousands separators: 1,583,145
            2 → show 2 decimal places: .22
            */
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
                Console.WriteLine($"Result: {choice}");
                Console.WriteLine("Invalid option, select 1 or 2.");
                // choice = 0;
                goto entry;
            }

        } while (choice != 2);
        Console.WriteLine("Thank you for using Bank Interest Calculator.");
    }
}