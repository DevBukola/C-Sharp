using System;

namespace L2ETalentInventory.DTOs
{
    //DTO for going out (viewing):
    public class SkillDto
    {
        public int Id { get; set; }
        public required string Title { get; set; }
    }
}