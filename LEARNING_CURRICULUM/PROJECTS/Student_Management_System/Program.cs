using System;
using System.Runtime.CompilerServices;

class StudentManagementSystem
{
    List<string> students = new List<string>
      {
            "Oluwabukola",
            "Simi",
            "Ifeoluwa",
      };

    Dictionary<int, string> studentRecords = new Dictionary<int, string>
    {
        {101, "Opeyemi"},
        {102, "Iremide"},
        {103, "Rejoice"},
    };

    Dictionary<int, HashSet<string>> studentCourses = new Dictionary<int, HashSet<string>>
    {
        {
            101,

            new HashSet<string>
            {
                "C#",
                "Mathematics",
            }
        },
        {
            102,

            new HashSet<string>
            {
                "Computer Engineering",
                "Biochemistry",
            }
        },
        {
            103,

            new HashSet<string>
            {
                
            }
        }
    };


    static void Main(string[] arguments)
    {
        StudentManagementSystem program = new StudentManagementSystem();
        program.Run();
        // int choice = program.GetMenuChoice();
        // program.HandleChoice(choice);
        // program.AddStudent();
        // program.SearchStudent();
        // program.RemoveStudent();
        // program.DisplayStudents();
        // program.AddStudentRecord();
        // program.SearchStudentByID();
        // program.RemoveStudentByID();
    }
    
    void Run()
    {
        int option;
        do
        {
            option = GetMenuChoice();
            HandleChoice(option);
        } while (option != 0);
    }

    void ShowMenu()
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("          STUDENT MANAGEMENT SYSTEM");
        Console.WriteLine("==============================================");

        Dictionary<int, string> menuList = new Dictionary<int, string>
        {
            {1,        "Add Student"},
            {2,        "Search Student"},
            {3,        "Remove Student"},
            {4,        "Display Students"},
            {5,        "Add Student Record"},
            {6,        "Display Students Record"},
            {7,        "Search Student By ID"},
            {8,        "Remove Student By ID"},
            {9,        "Register Course"},
            {10,       "Delete Student Course"},
            {11,       "Display Student Courses"},
            {12,       "Display All Students and Courses"},
            {0,        "Exit"},
        };
        foreach (KeyValuePair<int, string> menu in menuList)
        {
            Console.WriteLine($"{menu.Key}. {menu.Value}");
        }
    }

    int GetMenuChoice()
    {
        ShowMenu();
        Console.Write("Choose an option: ");
        bool isNumber;
        isNumber = int.TryParse(Console.ReadLine(), out int choice);
        if (!isNumber)
        {
            Console.WriteLine("Option must be a number.");
        }
        Console.WriteLine();
        return choice;
    }

    void HandleChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                AddStudent();
                break;
            case 2:
                SearchStudent();
                break;
            case 3:
                RemoveStudent();
                break;
            case 4:
                DisplayStudents();
                break;
            case 5:
                AddStudentRecord();
                break;
            case 6:
                DisplayStudentsRecord();
                break;
            case 7:
                SearchStudentByID();
                break;
            case 8:
                RemoveStudentByID();
                break;
            case 9:
                AddCourseToStudent();
                break;
            case 10:
                DeleteCourseFromStudent();
                break;
            case 11:
                DisplayStudentCourses();
                break;
            case 12:
                DisplayAllStudents();
                break;
            case 0:
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }
    
    void DisplayAllStudents()
    {
        foreach(KeyValuePair<int, string> student in studentRecords)
        {
            Console.WriteLine($"{student.Key} - {student.Value}");
            Console.WriteLine("Courses:");
            // foreach (string course in studentCourses[student.Key])
            // {
            //     Console.WriteLine(course);

            // }
                if (studentCourses[student.Key].Count > 0)
            {
                for (int i = 0; i < studentCourses[student.Key].Count; i++)
                {
                    Console.WriteLine($"{i+1}. {studentCourses[student.Key].ElementAt(i)}");

                }
            } else
            {
                Console.WriteLine("No courses registered.");
            }

            Console.WriteLine();
        }
    }

    void AddStudent()
    {
        Console.Write("Enter a student name: ");
        string name = Console.ReadLine()!;
        students.Add(name);
        Console.WriteLine($"Student \"{name}\" added successfully!");
    }

    void SearchStudent()
    {
        Console.Write("Enter a student name to search: ");
        string studentSearch = Console.ReadLine()!;
        if (students.Contains(studentSearch))
        {
            Console.WriteLine($"Student \"{studentSearch}\" found!");
        }
        else
        {
            Console.WriteLine($"Student \"{studentSearch}\" not found!");
        }
    }

    void RemoveStudent()
    {
        Console.Write("Enter a student name to remove: ");
        string studentRemove = Console.ReadLine()!;
        if (students.Contains(studentRemove))
        {
            students.Remove(studentRemove);
            Console.WriteLine($"Student \"{studentRemove}\" removed!");
        }
        else
        {
            Console.WriteLine($"Student \"{studentRemove}\" not found.");

        }
    }

    void DisplayStudents()
    {
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
    void AddStudentRecord()
    {
        bool isNumber;
        Console.Write("Enter a student ID: ");
        isNumber = int.TryParse(Console.ReadLine(), out int studentID);
        if (!isNumber)
        {
            Console.WriteLine("ID must be a number.");
        }
        else
        {
              if (studentRecords.ContainsKey(studentID))
            {
                Console.WriteLine("ID already exists.");
                return;
            } else
            {
                 Console.Write("Enter the student's name: ");
            string studentName = Console.ReadLine()!;

            studentRecords.Add(studentID, studentName);
            Console.WriteLine($"{studentName} with the ID: {studentID} has been added successfully!");
            studentCourses.Add(studentID, new HashSet<string>()); //Create an empty course list for this student and store it using their ID. Without this, registering a course for newly added student record from the terminal (not hard-coded in the studentRecords Dictionary) will result in "ID does not matchany student".
            }
           
        }
    }

    void DisplayStudentsRecord()
    {
        foreach(KeyValuePair<int, string> studentRecord in studentRecords)
        {
            Console.WriteLine($"{studentRecord.Key} - {studentRecord.Value}");
        }
    }

    void SearchStudentByID()
    {
        bool isNumber;
        Console.Write("What is the ID of the student you want to search for?: ");
        isNumber = int.TryParse(Console.ReadLine(), out int IDSearchInput);
        if (!isNumber)
        {
            Console.WriteLine("Input must be a number");
            return;
        }
        else
        {
            if (studentRecords.ContainsKey(IDSearchInput))
            {
                Console.WriteLine($"Student found: {studentRecords[IDSearchInput]}.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }

    void RemoveStudentByID()
    {
        bool isNumber;
        Console.Write("What is the ID of the student you want to remove?: ");
        isNumber = int.TryParse(Console.ReadLine(), out int IDRemoveInput);
        if (!isNumber)
        {
            Console.WriteLine("Input must be a number");
            return;
        }
        else
        {
            if (studentRecords.ContainsKey(IDRemoveInput))
            {
                string studentName = studentRecords[IDRemoveInput];
                studentRecords.Remove(IDRemoveInput);
                Console.WriteLine($"Student found and removed: {studentName}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }

    void AddCourseToStudent()
    {
        bool isNumber;
        Console.Write("What is the student ID?: ");
        isNumber = int.TryParse(Console.ReadLine(), out int studentID);
        if (!isNumber)
        {
            Console.WriteLine("Input must be a number.");
            return;
        }
        else
        {
            if (studentRecords.ContainsKey(studentID))
            {
                Console.Write("Enter the course name you want to register: ");
                string courseName = Console.ReadLine()!;
                if (studentCourses[studentID].Contains(courseName))
                {
                    Console.WriteLine("Course exists already.");
                }
                else
                {
                    studentCourses[studentID].Add(courseName);
                    Console.WriteLine($"{courseName} added successfully.");
                }
            }
            else
            {
                Console.WriteLine("ID does not match any student.");
            }

        }
    }
    
    void DeleteCourseFromStudent()
    {
         bool isNumber;
        Console.Write("What is the student ID?: ");
        isNumber = int.TryParse(Console.ReadLine(), out int studentID);
        if (!isNumber)
        {
            Console.WriteLine("Input must be a number.");
            return;
        }else
        {
            if (studentRecords.ContainsKey(studentID))
            {
                Console.Write("Enter the course you want to delete: ");
                string removeCourse = Console.ReadLine()!;
                if (!studentCourses[studentID].Contains(removeCourse))
                {
                    Console.WriteLine("Course does not exist.");
                    return;
                } else
                {
                    studentCourses[studentID].Remove(removeCourse);
                    Console.WriteLine("Course deleted successfully.");
                }
            }else
            {
                Console.WriteLine("ID does not match any student.");
            }
        }
    }
    
    void DisplayStudentCourses()
    {
        bool isNumber;
        Console.Write("What is the ID of the student whom you want their courses displayed?: ");
        isNumber = int.TryParse(Console.ReadLine(), out int studentID);
        if (!isNumber)
        {
            Console.WriteLine("Input must be a number.");
            return;
        }
        else
        {
            if (studentRecords.ContainsKey(studentID))
            {
                Console.WriteLine($"{studentID} - {studentRecords[studentID]}");
                Console.WriteLine("Courses:");

                // foreach(string course in studentCourses[studentID])
                // {
                //         Console.WriteLine(course);
                // }
                if (studentCourses[studentID].Count > 0)
                {
                    for (int i = 0; i < studentCourses[studentID].Count; i++)
                    {
                         Console.WriteLine($"{i + 1}. {studentCourses[studentID].ElementAt(i)}");
                    }
                }
                else
                {
                    Console.WriteLine("No courses registered.");
                }
            }
            else
            {
                Console.WriteLine("ID does not match any student");
            }
        }
        Console.WriteLine();
    }
    
}