using System;

/*
    Suppose we have:
    string status = "Pending";
    The problem is that someone could accidentally write:
    status = "Pendig";
    status = "pending";

    C# won't stop them because they are all valid strings.
    An enum lets us define a fixed set of allowed choices:

    enum Status {
        Pending,
        Approved,
        Rejected
    }

    Now, 
    Status status = string.Pending;
    We cannot accidentally assign an arbitrary string to status.
    Enums are useful for things like:
    OrderStatus
    PaymentStatus
    UserRole
    DayOfWeek
    Gender
    Direction

    Enum can be thought of as a data type whose possible values are a predefined set of named choices.
*/

Status status = Status.Pending;
Console.WriteLine(status);

OrderStatus order = OrderStatus.Shipped;
Console.WriteLine(order);
enum Status
{
    Pending,
    Approved,
    Rejected
}

enum OrderStatus
{
    Pending,
    Shipped,
    Delivered,
    Cancelled
}