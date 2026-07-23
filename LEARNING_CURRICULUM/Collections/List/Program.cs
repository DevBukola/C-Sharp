using System;
using System.Collections.Generic;

public class Collections{
    static void Main(string[] arguments)
    {
        int[] nums = new int[5];
        nums[0] = 5;
        nums[1] = 5;
        nums[2] = 7;
        nums[3] = 9;
        nums[4] = 10;


            Console.WriteLine("======Array======");
        foreach (int num in nums)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();


        List<int> numbers = new List<int>();
        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);
        numbers.Add(70);
        //remove by a specific value
        numbers.Remove(50);
        //remove by index
        numbers.RemoveAt(0);
        //remove by range
        // numbers.RemoveRange(0, 3);

        numbers.AddRange(new int[] { 3, 30, 4, 6, 5 });

        Console.WriteLine("======List======");
        Console.WriteLine(numbers.Count);
        foreach (int number in numbers)
        {
            Console.Write(number + " ");

        }
        Console.WriteLine();
        Console.WriteLine(numbers[0]);



        //=========DICTIONARY=========
        Dictionary<int, string> students = new Dictionary<int, string>();
        students.Add(10001, "Oluwadarasimi");
        students.Add(10002, "Stephen");
        students.Add(10003, "Iremide");
        students.Add(10004, "Daniel");


        Console.WriteLine("======DICTIONARY======");
        Console.WriteLine(students[10001]);
        Console.WriteLine(students.Count);

        foreach (KeyValuePair<int, string> student in students)
        {
            Console.WriteLine($"ID:{student.Key} - Name:{student.Value}");
            // Console.WriteLine(customers[customer]);
        }

        //looping through only the keys.
        foreach (int i in students.Keys)
        {
            Console.WriteLine(i);
        }

        //looping through only the value
        foreach (string i in students.Values)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        //========HASHSET========
        /*
            A hashset is a collection that stores unique values.
            Imagine this:
                Shopping cart:
                Apple
                Apple
                Banana
            The two Apples might represent two items purchased. A List<T> allows duplicates and that is perfectly fine when duplicates are meaningful. But sometimes you want every value must be unique. For example:
                Registered usernames:
                Oluwabukola
                Simi
                Oluwabukola
            You don't want Oluwabukola to appear twice. This is where Hashset<T> comes in.
        */

        HashSet<string> usernames = new HashSet<string>();
        usernames.Add("Oluwabukola");
        usernames.Add("Simi");
        usernames.Add("Oluwabukola");// this is not rendered. only one "Oluwabukola" is still printed.

            Console.WriteLine("======HASHSET======");
        foreach (string username in usernames)
        {
            Console.WriteLine(username);
        }

        //Checking whether a value exists:
        HashSet<string> names = new HashSet<string>
        {
            "Simi",
            "Gabriel",
            "Oluwatoyin",
            "Opeyemi",
            "Olajide",
        };
        /* Console.WriteLine(names[0]); 
        unlike List, HashSet does not have indexes and indexing cannot be applied, because the main purpose of a HashSet is uniqueness and fast memberhip checking, and not "Give me the item at position 0".
        */

        string searchName = "Olajide";
        if (names.Contains($"{searchName}"))
        {
            Console.WriteLine($"{searchName} exists");
        }
        else
        {
            // Console.WriteLine($"The name \"Olajide\" does not exist");
            Console.WriteLine($"The name {searchName} does not exist");

        };

        //Removing values
        names.Remove("Simi");
        // foreach (string name in names)
        // {
        //     Console.WriteLine(name);
        // }
        names.Clear();
         foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}