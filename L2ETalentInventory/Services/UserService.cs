using System;
using L2ETalentInventory.DTOs;
using L2ETalentInventory.Models;
using L2ETalentInventory.Repositories;

namespace L2ETalentInventory.Services;

    class UserService
    {
        private readonly UserRepository _userRepository;

    //constructor:
    public UserService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public UserDto CreateUser(CreateUserDto dto)
    {
        var newUser = new User
        {
            Id = GenerateNewId(),
            Name = dto.Name,
            BVN = dto.Name
        };

        _userRepository.AddUser(newUser);

        return new UserDto
        {
            Id = newUser.Id,
            Name = newUser.Name,
            Skills = new List<SkillDto>()
            //BVN = newUser.BVN, //throws error because we are not sending out BVN in out dto.
        };
    }

    public List<UserDto> ReadAllUsers()
    {
        var allUsers = _userRepository.GetAllUsers();

        return allUsers.Select(u => new UserDto
        {
            Id = u.Id,
            Name = u.Name,
            // BVN = u.BVN,
            Skills = new List<SkillDto>()
        }).ToList();
    }

    public UserDto? ReadUserById()
    {

        var singleUser = _userRepository.GetUserById(1);
        if (singleUser == null)
        {
            return null;
        }

        return new UserDto
        {
            Id = singleUser.Id,
            Name = singleUser.Name,
        };

    } 
    
    public UserDto EditUser(UpdateUserDto dto)
    {
        var updatedUser = new User
        {
            Name = dto.Name,
        };
        _userRepository.UpdateUserById(1, updatedUser);

        return new UserDto
        {
            Name = updatedUser.Name,
            Id = updatedUser.Id,
        };
    }
        private int GenerateNewId()
    {
        var allUsers = _userRepository.GetAllUsers();
        if (allUsers.Count == 0) return 1;
        return allUsers.Max(u => u.Id) + 1;
    }
    }
