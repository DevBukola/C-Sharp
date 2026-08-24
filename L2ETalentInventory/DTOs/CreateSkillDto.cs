using System;

namespace L2ETalentInventory.DTOs
{
    //DTO for going in (create):
    public class CreateSkillDTo
    {
        public int UserId { get; set; }
        public required string Title { get; set; }
    }
}