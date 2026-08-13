/* 
Access Modifiers: Who's Allowed to Touch What.
Access modifiers control visibility; which parts of your code are allowed to see or use a class, field, or method. This exists for one core reason: encapsulation — hiding internal details so other code can't mess with your object's insides in ways that break it.

Let us think of it like a house: some rooms are for guests (public), some are family-only (private), some are for family and close relatives (protected).

Below are the modifiers, from open to most restrictive:
- Public:
Anyone, anywhere, can access it. E.g:

public string Color; //any code can read or write this.

- Private:
Only code inside the same class can access it. This is the default if we write nothing.

- Protected:
Accessible in the same class and any class that inherits from it (a subclass), but not from outside.

- Internal:
Accessible anywhere within the same project/assembly, but not from another project that references it.
*/


//Private modifier example:
Animal animal = new Animal();

Dog dog = new Dog();
dog.MakeSound();

BankAccount account = new BankAccount();
//account.balance = 10_000; // balance is inaccessible due its protection level. Because we used private!


account.Deposit(20_000);
class BankAccount
{
    private decimal balance; // only BankAccount'sown code can access it.

    public void Deposit(decimal amount)
    {
        balance = 20_000; // though private, balance is accessible here because it belong to the same class as "Check". So, it means fine, we are inside the same class.
        Console.WriteLine(balance += amount);
    }
    /*
        This is the heart of encapsulation: outside code can't directly reach in and corrupt your data. It has to go through methods you control (like Deposit), so you can add rules ("no negative deposits!") that can't be bypassed.
    */
}


class Animal
{
    protected string sound = "generic sound";
}

class Dog : Animal
{
    public string sound = "real sound";
    public void MakeSound()
    {
        Console.WriteLine(sound);
        Console.WriteLine(base.sound);
    }
}