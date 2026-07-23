using System;
using System.ComponentModel.DataAnnotations;

class PasswordStrength
{
    static dynamic password;
    static int passwordLength;
    static bool hasUppercase;
    static bool hasLowerCase;
    static bool hasSpecialCharacter;
    static bool isNumber;
    static int score = 0;
    static string strength;

    static void TakeInput()
    {
        do
        {
            Console.Write("Enter your password: ");
            password = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Password cannot be empty");
            }
        } while (string.IsNullOrWhiteSpace(password));
        // Console.WriteLine($"Password: {password}");
    }

    static void CheckLenAndCase()
    {
        passwordLength = password.Length;
        foreach (char c in password)
        {
            if (char.IsUpper(c))
            {
                hasUppercase = true;
            }
            else if (char.IsLower(c))
            {
                hasLowerCase = true;
            }
            else if (!char.IsLetterOrDigit(c))
            {
                hasSpecialCharacter = true;
            }
        }

        if (passwordLength >= 8)
        {
            score += 1;
        }
        else if (hasUppercase == true)
        {
            score += 1;
        }
        else if (hasLowerCase == true)
        {
            score += 1;
        }
        else if (hasSpecialCharacter == true)
        {
            score += 1;
        }
    }
    
    static void CheckPassStrength()
    {
        if (passwordLength < 6)
        {
            strength = "Very weak";
        }
        else if (score == 1)
        {
            strength = "Weak";
        }
        else if (score == 2)
        {
            strength = "Moderate";
        }
        else if (score == 3)
        {
            strength = "Strong";
        }
        else if (score == 4)
        {
            strength = "Very strong";
        }
        else
        {
            strength = "Poor";
        }
        
        if (strength == "Very weak")
        {
            Console.WriteLine("Your password is very short");
        } else if (hasUppercase == false)
        {
            Console.WriteLine("Add at least one uppercase letter");
        } else if (hasLowerCase == false)
        {
            Console.WriteLine("Add at least one lowercase letter");
        } else if (hasSpecialCharacter == false)
        {
            Console.WriteLine("Add at least one special character");
        }
     }


    static void Main(string[] arguments)
    {
        int option;
        do
        {
            TakeInput();
            CheckLenAndCase();
            CheckPassStrength();
        entry:
            Console.WriteLine("Do you want to check the strength of another password or exit?");
            Console.WriteLine("1 - Yes.");
            Console.WriteLine("2 - No, exit.");

            isNumber = int.TryParse(Console.ReadLine(), out option);
            if (!isNumber)
            {
                Console.WriteLine("Option must be a number. Kindly type 1 or 2.");
                goto entry;
            }
            if (option != 1 && option != 2)
            {
                Console.WriteLine("Invalid entry. Option must be either 1 or 2");
                goto entry;
            }

        } while (option != 2);
        Console.WriteLine("Thank you for using Password Strength Checker.");
    }
}