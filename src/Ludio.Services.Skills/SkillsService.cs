using System.Collections.Generic;

namespace Ludio.Services.Skills
{
    public class SkillsService : ISkillsService
    {
        public IEnumerable<Skill> GetSkills()
        {
            var skill1 = GetSkill(1);
            var skill2 = GetSkill(2);
            var skill3 = GetSkill(3);
            var skill4 = GetSkill(4);
            var skill5 = GetSkill(5);
            var skill6 = GetSkill(6);

            return new List<Skill> {skill1, skill2, skill3, skill4, skill5, skill6};
        }

        public Skill GetSkill(int id)
        {
            Skill skill = new Skill { Id = id };
            if (id == 1)
            {
                skill.Name = "Flying";
                skill.Type = "Scratch";
            }
            else if (id == 2)
            {
                skill.Name = "Spawning objects";
                skill.Type = "Scratch";
            }
            else if (id == 3)
            {
                skill.Name = "Pickups";
                skill.Type = "Scratch";
            }
            else if (id == 4)
            {
                skill.Name = "Collision boxes";
                skill.Type = "Scratch";
            }
            else if (id == 5)
            {
                skill.Name = "Conditional loops";
                skill.Type = "Programming";
            }
            else if (id == 6)
            {
                skill.Name = "Creating methods";
                skill.Type = "Programming";
            }

            return skill;
        }
    }
}