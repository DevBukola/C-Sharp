using System;
using System.Linq;
using L2ETalentInventory.Models;

namespace L2ETalentInventory.Repositories
{
    public class SkillRepository
    {
        private readonly List<Skill> _skills = new List<Skill>();

        public void AddSkill(Skill skill)
        {
            _skills.Add(skill);
        }

        public List<Skill> GetAllSkills()
        {
            return _skills;
        }

        public List<Skill> GetSkillsByUserId(int userId)
        {
            // return _skills.FirstOrDefault(skill => skill.Id == id);
            return _skills.Where(skill => skill.UserId == userId).ToList();
        }

        public Skill? GetSkillById(int id)
        {
            return _skills.FirstOrDefault(skill => skill.Id == id);
        }
        public void UpdateSkillById(Skill updatedSkill)
        {
            var existingSkill = _skills.FirstOrDefault(skill => skill.Id == updatedSkill.Id);

            if (existingSkill != null)
            {
                existingSkill.Title = updatedSkill.Title;
            }
        }
        
        public void DeleteSkillById(int id)
        {
            var existingSkill = _skills.FirstOrDefault(skill => skill.Id == id);
            if(existingSkill != null)
            {
             _skills.Remove(existingSkill);
            }
        }
    }
}