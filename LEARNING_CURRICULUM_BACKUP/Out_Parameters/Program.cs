class OutParams
{
    // A method can only return one value using return. If you need to send additional values back to the caller, out is one way to do it.
    static bool Login(string username, out string message)
    {
        if (username == "Oluwabukola")
        {
            message = "Login successful";
            return true;
        }
        message = "Login unsuccessful";
        return false;
    }
    static void Main(string[] args)
    {
        string signin;
        Login("Oluwabukola", out signin);
        Console.WriteLine(signin);
    }
}