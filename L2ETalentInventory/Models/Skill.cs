using System;

namespace L2ETalentInventory.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public int UserId { get; set; }
    }
}