using System;

static int DisplayMenu()
{
    
    string menu = @"
    ===========BANK MENU===========
    1 - Check Balance
    2 - Deposit
    3 - Withdraw
    4 - Exit
    ";

    Console.Write(menu);
    Console.Write("Choose an option:");
    // int chosenMenu = Convert.ToInt32(Console.ReadLine());
    string typedMenu = Console.ReadLine()!;
    int.TryParse(typedMenu, out int chosenMenu);


    return chosenMenu;
}

static void bankingOperation()
{
    double Balance = 10000D;

    // Console.WriteLine("===========BANK MENU===========");
    // Console.WriteLine("1 - Check Balance");
    // Console.WriteLine("2 - Deposit");
    // Console.WriteLine("3 - Withdraw");
    // Console.WriteLine("4 - Exit");

    entry:
    int choice = DisplayMenu();

    switch (choice)
    {
        case 1:
            Console.WriteLine($"Your balance is: ${Balance}");
            Console.WriteLine("Do you want to perform another transaction?");
            string option = @"
            1 - Yes
            2 - No
            ";
            Console.WriteLine(option);
            Console.Write("Kindly select an option:");
            // var chosenOption = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine()!;
            if (int.TryParse(input, out int chosenOption))
            {
                if (chosenOption == 1)
                {
                    goto entry;
                } else if (chosenOption == 2)
                {
                    return;
                } else
                {
                    Console.WriteLine("Kindly choose between 1 and 2.");
                }
            } else
            {
                Console.WriteLine("Please, enter a number");
            }
            break;
        case 2:
                Console.Write("Enter an amount to deposit:");
                string deposit = Console.ReadLine()!;
            double.TryParse(deposit, out double depositedAmount);
                if (depositedAmount < 50)
            {
                Console.WriteLine("Amount is too small");
                return;
            }
                Balance = Balance + depositedAmount;
                Console.WriteLine($"You have successfully deposited ${depositedAmount}");
                Console.WriteLine($"Your new balance is ${Balance}");
                break;
        case 3: 
            Console.Write("Enter an amount to withdraw:");
            string withdrawal = Console.ReadLine()!;
            double.TryParse(withdrawal, out double withdrawalAmount);
            if (withdrawalAmount > Balance || withdrawalAmount < 50)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            } else
            {
                Balance = Balance - withdrawalAmount;
                 Console.WriteLine($"You have successfully withdrawn ${withdrawalAmount}");
                Console.WriteLine($"Your new balance is ${Balance}");
            }
            break;
        case 4:
            break;
        default:
            Console.WriteLine("Invalid Option. Kindly choose between 1, 2, 3, or 4.");
            break;
    }

}

bankingOperation();