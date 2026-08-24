using System;
using System.Linq;
using L2ETalentInventory.Models;

namespace L2ETalentInventory.Repositories
{
    public class UserRepository
    {
        private readonly List<User> _users = new List<User>();
        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public User? GetUserById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public void UpdateUserById(User updatedUser)
        {
            var existingUser = _users.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (existingUser != null)
            {
                existingUser.Name = updatedUser.Name;
                // existingUser.BVN = updatedUser.BVN;
            }
            // existingUser?.Name = updatedUser.Name;
        }

        public void DeleteUserById(int id)
        {
            var existingUser = _users.FirstOrDefault(u => u.Id == id);
            if(existingUser != null)
            {
             _users.Remove(existingUser);
            }
        }
    }
}