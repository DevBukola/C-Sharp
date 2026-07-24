using System;
using System.Collections.Generic;

public class Collections
{
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

        List<string> letters = new List<string>
        {
            "A", "B", "C", "D", "E"
        };

        letters.Insert(2, "X");

        foreach (string letter in letters)
        {
            Console.Write(letter + " ");
            // letters.Insert(2, "X");
        }
        Console.WriteLine();



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

        }
        ;

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
        Console.WriteLine();

        //========Queue========
        Console.WriteLine("======QUEUE======");
        //A Queue is a collection that stores items in the order they arrive and processes them using the FIFO (First In, First Out) rule, meaning the first item added is the first item removed; it is important whenever items need to be handled in an orderly sequence, like customers waiting in a bank, print jobs waiting for a printer, or tasks waiting to be processed, with "Enqueue" adding an item to the back, "Dequeue" removing and returning the item at the front, and "Peek" looking at the item at the front without removing it.

        //You you can access a Queue without a loop - access the nex item with Peek, access and remove the next item with Dequeue, access all items with a foreach loop, but you cannot directly access an item by index because the Queue's main rule is that items are processed from the front in the order they arrived.

        Queue<string> customers = new Queue<string>();
        customers.Enqueue("Oluwabukola");
        customers.Enqueue("Stephen");
        customers.Enqueue("Okechukwu");
        customers.Enqueue("Simi");


        while (customers.Count > 0)
        {
            Console.WriteLine($"Before removing: {customers.Count} people.");
            Console.WriteLine($"Next person to be attended to: {customers.Peek()}");
            string customer = customers.Dequeue();
            Console.WriteLine($"Removed: {customer}");
            Console.WriteLine($"After removing: {customers.Count} people.");
            Console.WriteLine();
        }
        Console.WriteLine();

        //======STACK======
        Console.WriteLine("======STACK======");
        //A Stack is almost the opposite f Queue. A Queue follows: FIFO - First In, First Out. A Stack follows LIFO - Last In, First Out. Let's think of a stack of plates: if you place Plate 1, then Plate 2, then Plate 3 on top, you must remove Plate 3 first because it is the one at the top. That is exactly how a Stack<T> works.
        /* You add:
        Plate 1
        Plate 2
        Plate 3

        The stack:
        Plate 3  - first to come out.
        Plate 2
        Plate 1 
        */
        // It's main operations are Push - add an item to the top, Pop - remove and return the item at the top, Peek - look at the item at the top without removng it. So the main difference is: Queue - first item added comes out first. Stack - last item added comes out first. Stacks are useful for things like undo operations, browser back buttons, and situations where the most recently added item needs t be handled first.
        Stack<string> tasks = new Stack<string>();
        tasks.Push("Subscribe to a platform");
        tasks.Push("Spread clothes outside");
        tasks.Push("Switch on the fan");
        tasks.Push("Write 10,000 lines of code in C#!");

        string undoTask = tasks.Pop(); // removes the last item added because it is now at the top ---- LIFO!
        Console.WriteLine($"Task undone: {undoTask}");


        foreach (string task in tasks)
        {
            Console.WriteLine($"Task: {task}"); //This prints: Swicth on the fan(id:3), Spread clothes outside(id:2), Subscribe to a platform(id:1) ---- LIFO!
        }
        Console.WriteLine();

        //======LIKEDLIST======
        Console.WriteLine("======LINKEDLIST======");
        /*
            Conceptually, a `LinkedList<T>` does not shift all the other items when you insert or remove an item, unlike List.
            Imagine:
            text:
            A ↔ B ↔ C ↔ D ↔ E 

            You want to insert "X" between "B" and "C".

            A `List<T>` might need to shift:

            text:
            C → D → E to create an empty position:

            text:
            A → B → X → C → D → E

            But a `LinkedList<T>` works more like changing connections:
            Before:

            text:
            B ↔ C

            After:

            text:
            B ↔ X ↔ C

            "C", "D", and "E" do not need to move to new index positions.

            A "List<T>" stores items in an indexed sequence, so inserting in the middle may require later items to shift. A "LinkedList<T>" stores nodes connected to one another, so inserting or removing a known node mainly involves changing those connections.

            However, there is an important detail: a "LinkedList<T>" still has to find the position or item first if you do not already have a reference to its node. So it is not automatically faster for everything. Its main advantage is inserting or removing items efficiently once you already know the node/location.

        */

        LinkedList<string> playlist = new LinkedList<string>();

        playlist.AddLast("Song A");
        playlist.AddLast("Song B");
        playlist.AddLast("Song C");
        playlist.AddLast("Song D");

        LinkedListNode<string> currentSong = playlist.Find("Song B")!;
        playlist.AddBefore(currentSong, "New Song");

        foreach(string song in playlist)
        {
            Console.WriteLine(song);
        }
    }
}