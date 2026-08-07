using System;
using System.IO;

const string fileName = "students.txt";

while (true)
{
    Console.WriteLine("\n===== STUDENT RECORD SYSTEM =====");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. View Students");
    Console.WriteLine("3. Exit");
    Console.Write("Choose an option: ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Enter Student ID: ");
            string? id = Console.ReadLine();

            Console.Write("Enter Student Name: ");
            string? name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            string? age = Console.ReadLine();

            string student = $"{id},{name},{age}{Environment.NewLine}";

            File.AppendAllText(fileName, student);

            Console.WriteLine("Student saved successfully!");
            break;

        case "2":
            if (File.Exists(fileName))
            {
                Console.WriteLine("\n===== STUDENTS =====");
                Console.WriteLine(File.ReadAllText(fileName));
            }
            else
            {
                Console.WriteLine("No students found.");
            }
            break;

        case "3":
            Console.WriteLine("Goodbye!");
            return;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}