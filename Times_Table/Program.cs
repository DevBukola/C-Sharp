using System;

namespace TimesTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kindly enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int column = 1; column <= 12; column++)
            {
                Console.WriteLine("{0} x {1} = {2}", number, column, number * column);
            }
        }
    }
}
