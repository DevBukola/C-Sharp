/*
LINQ stands for Language Integrated Query.
Query:
A query simply means:
Ask for data.

For example:
- Find all students older than 20.
- Find every product cheaper than ₦5,000.
- Find everyone whose name starts with "O".
- Sort employees by salary.

Those are all queries.
*/

using System.Linq;
using System.Text.Json;
// Where (filter items) and select (transform items)
List<Student> students = new List<Student>()
{
    new Student {Name = "Darasimi", Age = 20, Department = "Software Engineering" },
    new Student {Name = "Stephen", Age = 24,  Department = "Medicine & Surgery"},
    new Student {Name = "Opeyemi", Age = 16, Department = "Luxury Fashion and Styling" },
    new Student {Name = "Bashirat", Age = 16, Department = "Software Engineering" },
    new Student {Name = "Iremide", Age = 6, Department = "Medicine & Surgery"},
};



var result = students.Where(student => student.Age > 18).Select(s => s.Name);
// Console.WriteLine(result);

// foreach(Student student in result)
// {
//     Console.WriteLine(student.Name);
// }
Console.WriteLine(JsonSerializer.Serialize(result,new JsonSerializerOptions{WriteIndented = true}));
// foreach (Student student in result)
// {
//     // Console.WriteLine(student.Name);
//     // Console.WriteLine(student.Age);

// }

//OrderBy(sort data):
List<int> numbers = new List<int>()
{
    5,3,9,5,10,2,3,8,40,27,35,22,19,100,97,85,42
};

var sortedNumbers = numbers.OrderBy(number => number);
foreach (int num in sortedNumbers)
{
    // Console.Write(string.Join(", ", num ));
}

    // Console.WriteLine();



//First(), FirstorDefault(), Single(), and SingleorDefault()
Student firstStudent = students.First(learner => learner.Age > 20);
Console.WriteLine(firstStudent.Name);

Student? s = students.Find(st => st.Age < 20);
Console.WriteLine(s.Name);

Student? learner = students.FirstOrDefault(learner => learner.Age > 30);

if (learner != null)
{
    // Console.WriteLine(learner.Name);
}
else
{
    // Console.WriteLine("No learner found.");
}

List<string> names = new List<string>()
{
    "Praise",
    "John",
    "Daniel",
    "Bright",
    "Praise",
    "Peter",
    "Prince"
};

var singleName = names.Single(name => name == "John");
// Console.WriteLine(singleName);


try
{
    var name = names.SingleOrDefault(name => name == "Praise");
    if (name == null)
    {
        // Console.WriteLine("Name not found.");
    }
    else
    {
        // Console.WriteLine(name);
    }
}
catch (InvalidOperationException)
{
    // Console.WriteLine("More than one matching name was found.");
}

//Count()
int totalStudents = students.Count();
// Console.WriteLine(totalStudents);

int total = students.Count(student => student.Age > 20);
// Console.WriteLine(total);

bool check = students.Any(student => student.Age < 20);
// Console.WriteLine(check);

bool anyEven = numbers.Any(number => number % 2 == 0);
// Console.WriteLine(anyEven);

bool allEven = numbers.All(number => number % 2 == 0);
// Console.WriteLine(allEven);

//Take() and Skip()
var takeResult = numbers.Take(5); // take only the first five.

foreach (int number in takeResult)
{
    // Console.Write(number);
}
Console.WriteLine();
// Console.WriteLine();

var skipResult = students.Skip(1); // skip the first one and take others.

foreach (Student student in skipResult)
{
    // Console.WriteLine(student.Name);
}

var skipAndTakeResult = numbers.Skip(3).Take(5);
foreach (int number in skipAndTakeResult)
{
    // Console.WriteLine(number); // skip the first three and take the first five from what's left.
}

// Sum() adds all the numbers together.

int[] numerics = { 3, 4, 16, 99, 33, 2 };
int numericsTotal = numerics.Sum();
Console.WriteLine($"Sum of number: {numericsTotal}");

int totalStudentsAge = students.Sum(student => student.Age);
Console.WriteLine($"Students age total: {totalStudentsAge}");

//Min() finds the smallest value.
int smallestValue = numerics.Min();
Console.WriteLine($"Smallest number: {smallestValue}");

int youngest = students.Min(student => student.Age);
Console.WriteLine($"Youngest student's age: {youngest}");

// Max() finds the largest value.
int largestValue = numerics.Max();
Console.WriteLine($"Largest number: {largestValue}");

int oldest = students.Max(student => student.Age);
Console.WriteLine($"Oldest student's age: {oldest}");

// Average() finds the average. sum is 157/6 = 26.16
double averageValue = numerics.Average();
Console.WriteLine($"Numbers average: {averageValue}");

double averageAge = students.Average(student => student.Age);
Console.WriteLine($"Students age average: {averageAge}");


//GroupBy() means put things that have something in common into the same group.
var groups = names.GroupBy(name => name[0]);

foreach (var group in groups)
{
    Console.WriteLine(group.Key);
    foreach (var name in group)
    {
        Console.WriteLine(name);
    }
    Console.WriteLine();
}

var groupByDepartment = students.GroupBy(student => student.Department);
foreach (var group in groupByDepartment)
{
    Console.WriteLine(group.Key);
    foreach (var student in group)
    {
        Console.WriteLine(student.Name);
    }
}

var result2 = numbers
.Where(number => number >= 10)
.ToList();
Console.WriteLine($"result is: {string.Join(", ", result2)}");
Console.WriteLine(result2.GetType());

var result3 = students
.Where(student => student.Age > 10)
.OrderBy(s => s.Age)
.Select(s => s.Name)
.ToArray();

Console.WriteLine($"third result is: {string.Join(", ", result3)}");
Console.WriteLine(result3.GetType());

class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Department { get; set; }
}