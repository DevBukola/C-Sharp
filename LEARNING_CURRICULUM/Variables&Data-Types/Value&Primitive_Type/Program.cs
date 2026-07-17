using System;

class Demo
{
    static void Main(string[] args)
    {
        // C# stores its variables in two different ways: its value type which is stored in the area of memory called "STACK", and its reference type which is stored in the area of memory called "HEAP".
        static void ValueType()
        {

            /*
            Value Type = the variable stores the actual value.
            Value type = You own the actual item.
            Examples of value type are:
            - ints
            - bools
            - floats
            - structs
            - chars
            */
            /*
            Imagine two notebooks
            Scenario 1: Value Type
            Suppose you write number 300 in a notebook.

            Notebook A:
            Balance = 300.

            Now your friend copies your notebook.

            Notebook B:
            Balance = 300.

            Your friend now has their own copy. Did you notice?
            Now, if they erase and write:
            Balance = 600.
            What happens?
            Notebook A:
            Balance = 300.

            Notebook B:
            Balance = 600.

            Your value never changed. This is how value types work.
            */

            int notebookA = 300;
            int notebookB = notebookA;

            Console.WriteLine($"num 1: {notebookA}");
            Console.WriteLine($"num 2: {notebookB}");

            //300
            //300

            notebookB = 600;

            Console.WriteLine($"num 1: {notebookA}");
            Console.WriteLine($"num 2: {notebookB}");

            //300
            //600

            // Changing notebookB does not affect notebookA because the "value" was copied.
        }

        ValueType();

        static void ReferenceType()
        {
            /*
            Reference Type – the variable stores the address (reference) of the object, not the object itself.
            Reference type = You own a piece of paper with the location of the item.
            Examples of reference type are:
            - classes
            - array
            - lists
            - collections
            - strings
            */

            /*
            Scenario 2: Reference Type
            Now, imagine a TV in your living room.
            You have one TV:
                Samsung TV
                Volume = 20
                Channel = CNN
            Now, imagine you have two remote controls for that TV. One TV, two remote controls.
            Remote A and Remote B.
            Again, there are not two TVs. There is one TV. The remotes simply control it.
            If you use RemoteB to increase the volume to 50:
                Volume = 50.
            What hapens when you pickup RemoteA? Does it still see volume 20?
            No. It also sees volume 50, and that is because they both control the same TV.
            This is exactly what reference type is. The variables are the remotes. THe object is the TV.
            */

            //E.g:
            Person person1 = new Person();

            //person 1 = RemoteA
            // Person Object (TV)

            Person person2 = person1;

            //C# does not build another person, instead it gives you another remote. Both variables point to the same obeject.

            person1.Age = 25;
            person2.Name = "Daniel";
            /* That is like pressing the volume button on RemoteB.
            The object changes. Now if you ask:
            */

            Console.WriteLine(person1.Name);
            Console.WriteLine(person1.Age);

            //You get Daniel because there was only one object all along.

        }

        ReferenceType();
    }
    class Person
    {
    public string Name { get; set; } = "";
    public int Age; 
    }
}