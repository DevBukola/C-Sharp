using System;

class Type
{
    static void Main(string[] args)
    {
        static void TypeConversion()
        {
            /*
            Type Conversion is the process of changing a value from a data type to another. For example, converting int to a double and vice versa, a string to an int and vice versa.
            There are two main types of Type Conversion:
            1. Implicit Conversion:
                An implicit conversion happens automatically. C# performs it when there is no risk of losing data. It is like pouring water from a small cup into a larger bucket - nothing spills.
                Example:
                int number = 25;
                double result = number;
                No cast needed because every int can fit inside a double. Common implicit Conversions are: byte - short - int - long - float - double - decimal.
                Generally, converting from a smaller numeric type to a larger one is safe.

            2. Explicit Conversion(Casting):
            */

            // =========IMPLICIT CONVERSION=========
            int a = 99;
            double b = a;

            char letter = 'A';
            int ascii = letter;

            Console.WriteLine(b); //already a double but won't show if printed like this. But it becomes a double internally.
            Console.WriteLine(b.ToString("F1"));
            Console.WriteLine($"{b:F2}");
            Console.WriteLine(ascii);


            /*
            The F stands for Fixed-point format.
            The number after the F tells C# how many digits to show after the decimal point.
            */



            // =========EXPLICIT CONVERSION(CASTING)=========
            double price = 88.98;
            // int wholesale = price;
            //The above says: Cannot explicitly convert type 'double' to 'int'. An explicit conversion exists (are you missing a cast?)

            int wholeSale = (int)price;

            Console.WriteLine(price);
            // Console.WriteLine(wholesale);
            Console.WriteLine(wholeSale);

            int number = 97;
            char alphabet = (char)number;

            Console.WriteLine(alphabet);



            /* The designers of C# decided that implicit conversions should only happen when they are guaranteed not to lose information or change the meaning of the value.

            Imagine you are designing C#:
            Suppose you're one of the engineers creating the language and you have two types: int and double

            Now someone writes:
            int age = 25;
            double number = age;

            Should the compiler allow this automatically?

            Let us have a look:

            25 = 25.0

            Did anything get lost? No. The value is still exactly the same.

            So you tell the compiler:
            "This conversion is always safe. Go ahead and do it automatically."
            That's an implicit conversion.

            Now, let us consider the opposite:

            double price = 19.99;
            int amount = price;

            Should the compiler allow this automatically?

            Let us take a look:

            19.99 = 19

            Where did the .99 go?
            It's gone forever.
            Information was lost.

            If the compiler silently did this, bugs could appear without the programmer noticing.

            So the language designers said:

            "This conversion is potentially dangerous. The programmer must explicitly tell us they understand the risk."

            That's why we must write:

            int amount = (int)price;

            The cast is almost like signing a waiver.
            You're saying: "Yes, I know I might lose data. Do it anyway."
            */
        }

    TypeConversion();
}
}
