using System;
using L2ETalentInventory.Models;

namespace L2ETalentInventory.DTOs
{
    //DTO for going out (viewing):
    public class UserDto
    {
        public int Id { get; set; } 
        public string Name { get; set; } = "";
        public List<SkillDto> Skills { get; set; } = new List<SkillDto>();
    }
}