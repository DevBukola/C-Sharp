using System;

   public struct User {
    public string username;
    public string fullname;
    public int id;
    public int balance;
    public int deposit;
}
class RefParams
{
    static void IncreaseScore(ref int score)
    // A ref parameter allows a method to modify the caller's variable.
    {
        score = score + 25;

    }

    static void CreateUser()
    {
        User user1 = new User();
        user1.fullname = "Ofonime Udo";
        user1.id = 1;
        user1.balance = 500;

        CreateUsername(ref user1);
        Console.WriteLine($"here: {user1.username}");
        int updatedBalance = user1.balance += user1.deposit;
        Console.WriteLine($"Updated balance = {updatedBalance}");
    }
    
    static void CreateUsername(ref User targetuser)
    {
        System.Console.WriteLine("i ran");
        targetuser.username = "Oudo";
        Console.WriteLine($"{targetuser.username}");
        targetuser.deposit = 3000;
    }
    static void Main(string[] args)
    {
        int myScore = 10;
        IncreaseScore(ref myScore);
        Console.WriteLine(myScore);
        CreateUser();
    }
}