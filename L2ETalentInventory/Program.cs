using L2ETalentInventory.DTOs;
using L2ETalentInventory.Models;
using L2ETalentInventory.Repositories;
using L2ETalentInventory.Services;

var userRepository = new UserRepository();
var userService = new UserService(userRepository);

int choice;

do
{
    Console.WriteLine("======L2E Talent Inventory=======");
    Console.WriteLine("1. Create User");
    Console.WriteLine("2. Get All Users");
    Console.WriteLine("3. Get User By Id");
    Console.WriteLine("4. Update User By Id");
    Console.WriteLine("5. Delete User By Id");
    Console.WriteLine("0. Exit");


    Console.Write("Enter your choice: ");
    int.TryParse(Console.ReadLine(), out choice);

    switch(choice)
    {
        case 1:
            // Console.Write("Name: ");
            // string name = Console.ReadLine()!;

            var firstUserDto = new CreateUserDto
            {
                Name = "Oluwadarasimi",
                BVN = "12345678912",
            };

            var secondUserDto = new CreateUserDto
            {
                Name = "Ada",
                BVN = "22222233336"
            };
            var createdUser1 = userService.CreateUser(firstUserDto);
            var createdUser2 = userService.CreateUser(secondUserDto);
            Console.WriteLine("User created successfully!");

            Console.WriteLine($"Id: {createdUser1.Id}\nName: {createdUser1.Name}\n");
            Console.WriteLine($"Id: {createdUser2.Id}\nName: {createdUser2.Name}\n");
            break;

        case 2:
            Console.WriteLine("\nAll users:");
            var allUsers = userService.ReadAllUsers();

            if(allUsers.Count == 0)
            {
                Console.WriteLine("No user registered yet.");
            } else
            {
                  foreach (var user in allUsers)
            {
                Console.WriteLine($"Id: {user.Id}\nName: {user.Name}\n Skills: {user.Skills}");
            }
            }
            break;

        case 3:
            var oneUser = userService.ReadUserById();
            Console.WriteLine($"Id: {oneUser?.Id}\nName: {oneUser?.Name}");
            break;
        case 4:
            var updatedUser = new UpdateUserDto
            {
                Name = "Simi"
            };
            var result = userService.EditUser(updatedUser);
            Console.WriteLine($"User {result.Name} updated successfully.");
            break;
            
        case 0:
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid entry");
            break;
    }


}while (choice != 0);