using System;

namespace L2ETalentInventory.DTOs
{
    public class CreateUserDto
    {
        public required string Name { get; set; }
        public required string BVN { get; set; }
    }
}