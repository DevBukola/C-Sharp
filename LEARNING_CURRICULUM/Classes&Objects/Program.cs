
/*
What is a Class?
Let's think of a class as a blueprint, and an object as the thing built from that blueprint.
A blueprint for a house is not a house that one can live in; it just describes what a house should have (rooms, doors, window) and what it can do (open a door, turn on lights). The actual house we build from that blueprint is the object.
*/

using System;
using System.Drawing;

class Classes
{
    static void Main(string[] args)
    {

        Toyota toyota = new Toyota("Toyota", "Red", "Ford");
        Console.WriteLine($"here:{toyota.Color}, {toyota.Brand}, {toyota.Model}");
        Car myCar = new Car("Blue", "Forde"); //forced to supply both arguments values because of constructor.
        //Without a costructor, you'd create an object and then manually set every field, one by one, and might forget one:
        myCar.Color = "Green";
        //// forgot to set Model; now myCar.Model is null. Bug waiting to happen.
        myCar.Honk();

        Console.WriteLine(myCar.Color);
        Console.WriteLine(myCar.Model);
        Console.WriteLine(myCar.Model);

        Car yourCar = new Car("Red", "Toyota"); //forced to supply both arguments now because of constructor.
        yourCar.Color = "Blue";
        yourCar.Model = "Toyota";

        Console.WriteLine(yourCar.Color);
        Console.WriteLine(yourCar.Model);

        /*
            NB: myCar and yourCar are two separate objects, each with their own Color and Model. The class just defines the shape; each object holds its own data.

            Key vocabulary:
            Class = the blueprint/template.
            Object (or instance) = a real thing made from that blueprint.
            Field = a variable that lives inside a class (Color, Model).
            Method = a function that lives inside a class (Honk()).
        */

        Student student = new Student("Bukola", 25);
        Console.WriteLine(student.Name);


        //Creating objects with an overloaded constructor:
        Fellow fellow1 = new Fellow();
        Fellow fellow2 = new Fellow("Oluwabukola", "Muritala");
        Console.WriteLine($"{fellow2.FirstName} {fellow2.LastName}");

        Fellow fellow3 = new Fellow("Stephen", "Asadu", "L2E059");
        Console.WriteLine($"{fellow3.FirstName} {fellow3.LastName} with an id of {fellow3.FellowId}");

        Learner learner = new Learner();
        learner.Age = 20;
        Console.WriteLine(learner.Age);


        Book book = new Book();
        book.Author = "Simi Daniel";
        book.Title = "Alchemy of Age";
        book.Pages = 26;

        Console.WriteLine($"{book.Author} is the author of the book \"{book.Title}\", and there are {book.Pages} pages in it.");


        Book2 book2 = new Book2();

        book2.Pages = 28;

        Console.WriteLine(book2.Pages);
    }



        //The blueprint (class)
    class Car(string color, string model)
    {
        public string? Color = color;
        public string? Model = model;

        public void Honk()
        {
            Console.WriteLine("Beeb beep!");
        }

        //Constructor: A constructor is special code that runs automatically the moment you create an object with new. Its job: make sure the object starts life in a valid, ready-to-use state.

    }


    class Toyota(string brand, string color, string model) : Car(color, model)
    {
        public string Brand = brand;
    }





    class Student
    {
        public string Name;
        public int Height;

        /* The this Keyword:
            Here, "this" refers to the curent object being created. Sometimes it's requred sometimes it is optonal. For example, in the constructor below, where the constructor has the same naming parameter as the class' fields, without "this", C# wouldn't know whether "Name" and "Height" refer to the parameters or the fields.
        */

        public Student(string Name, int Height)
        {
            this.Name = Name;
            this.Height = Height;
        }
    }


    //CONSTRUCTOR OVERLOADING:
    /*
        A class can have multiple constructrs, as long as their parameter lists are different. Similar to Method Overloading? Will check later.
        Example:
    */
    class Fellow
    {
        public string FirstName;
        public string LastName;
        public string FellowId;


        //Constructor overloading:

        public Fellow() // without parameters
        {

        }

        public Fellow(string firstName, string LastName) // with only one parameter
        {
            FirstName = firstName;
            this.LastName = LastName;
        }

        public Fellow(string FirstName, string lastName, string FellowId)
        {
            this.FirstName = FirstName;
            LastName = lastName;
            this.FellowId = FellowId;
        }
    }




    //PROPERTIES(get & set)
    /*
        
    */
    class Learner
    {
        private int age;

        public int Age
        {
            /*
                set runs when you assign a value.
                get runs when you read a value
            */
            get { return age; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Age must be greater than 0.");
                age = value;
            }
            // set
            // {
            //     if (value > 0)
            //     {
            //         age = value;
            //     } else
            //     {
            //         Console.WriteLine("Wrong");
            //     }
            // }
        }
    }


    //Auto-implemented properties:

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
    }
    
    
    class Book2
{
    private int pages;

    public string Title { get; set; }
    public string Author { get; set; }

    public int Pages
    {
        get
        {
            Console.WriteLine("Getter called.");
            return pages;
        }

        set
        {
            Console.WriteLine($"Setter called with {value}.");
            pages = value;
        }
    }
}
}