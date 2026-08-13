using System;

class Solution
{
    public static void PrintArrLength()
    {
        int[] numbers = new int[5];
        // Console.WriteLine(numbers.Length);

        int[] data = { 3, 5, 68, 9, 5, 3, 2, 2, 1, 9, 5, 7 };

        int last = data[^1];
        int secondLast = data[^2];
        int tenLast = data[^10];
        //int zeroLast = data[^0]; // index out of range(it equals length).
// 
        // Console.WriteLine($"{last}\t{secondLast}\t{tenLast}");

        int[,] nums = {
            {1, 2, 3, 4, 5, 6, 7, 9,},
            {4,6,8,9,7,9,0,8},
            {6,8,0,6,3,1,2,6},
        };


        Console.WriteLine(nums[2,4]);
        for (int row = 0; row < 3; row++)
        {
            for (int column = 0; column < 8; column++)
            {
                Console.Write(nums[row, column] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        PrintArrLength();
    }
}