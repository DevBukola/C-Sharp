using System;

/*
    Null basically means there is no object/value here.
    For instance:
    string? name = null;
    This means name = nothing.
    It does not mean an empty string "", 0, false. Those are actual values.
*/

//Why does null matter? Let's imagine this:
string? name = null;
// Console.WriteLine(name.Length);

/* What should C# do?
There is no string, so there is no .Length.
We will get a NullReferenceException at runtime.
That is one of the most important errors one will encounter in C#.
We can simply do:
*/

if (name != null)
{
    Console.WriteLine(name.Length);
}

/*
    The ? means this reference is allowed to contain null. Compare string name to string? name. The second one explicitly says "I know this might be null." This is part of C# nullable reference type system.
*/

//The ?? Operator
string? username = null;
string displayUsername = username ?? "Unknown";
Console.WriteLine(displayUsername);
/*
    Read this as "Use username, but if it is null, use Unknown instead."
*/

string? surname = null;
Console.WriteLine(surname?.Length);

/* 
    The ?. (the null-conditional) Operator:
    Means: "If this is not null, access the length. If it is null, don't throw an exception."
    So instead of surname.Length which can crash when surname is null, we use surname?.Length
*/

