using System;

Student student = new Student();
Student student01 = new Student("Patience", "Udo");
Console.WriteLine($"{student01.FirstName} {student01.LastName}");

Student student02 = new Student("Stephen", "Asadu", 059);
Console.WriteLine($"{student02.FirstName} {student02.LastName} with id {student02.MatricNumber} {student02.ToString()}");

Learner learner = new Learner();
learner.Age = -20;
Console.WriteLine(learner.ToString());

Console.WriteLine("===== Account 1 =====");
BankAccount account1 = new BankAccount(8000);
Console.WriteLine($"Balance before deposit: {account1:N2}");
account1.Deposit(2_000_000);
Console.WriteLine($"Balance after deposit: {account1:N2}");
Console.WriteLine();

Console.WriteLine("===== Account 2 =====");
BankAccount account2 = new BankAccount(65_000);
Console.WriteLine($"Balance before deposit: {account2}");
account2.Deposit(5_276_439);
Console.WriteLine($"Balance after deposit: {account2}");

class Student
{
    public string FirstName;
    public string LastName;
    public int MatricNumber;

    //Constructor overloading:
    public Student()
    {

    }

    public Student(string FirstName, string lastName)
    {
        this.FirstName = FirstName;
        LastName = lastName;
    }

    public Student(string FirstName, string LastName, int matricNum)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        MatricNumber = matricNum;
    }
}

class Learner
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
                Console.WriteLine("Invalid");
            else
                age = value;
        }
    }

    public override string ToString()
    {
        return $"{age}";
    }

}


class BankAccount
    {
        // public decimal Balance { get; private set; } = 5000;

        public decimal Balance { get; private set; }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount >= 50)
        {
            Console.WriteLine($"Amount deposited: {amount:N2}");
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Deposit amount is too small.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
                return;
            }
        }

        public override string ToString()
        {
            return $"{Balance:N2}";
        }
    }