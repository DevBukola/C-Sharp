class Params
{
    static int FindLargestNum(params int[] numbers)
    // The params keyword lets a method accept any number of arguments of the same type. Instead of writing many overoads, you write one method.
    {
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        return largest;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(FindLargestNum(10, 14, 5));
        Console.WriteLine(FindLargestNum(2,4,5,9,9));
        Console.WriteLine(FindLargestNum(60,44,23,19,5,8));
        Console.WriteLine(FindLargestNum(10,14,5,100,1000,100000,5000000,50,67,105));
        
    }
}