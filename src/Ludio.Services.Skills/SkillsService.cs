using System.Collections.Generic;

namespace Ludio.Services.Skills
{
    public class SkillsService : ISkillsService
    {
        public IEnumerable<Skill> GetSkills()
        {
            var skill1 = GetSkill(1);
            var skill2 = GetSkill(2);

            return new List<Skill> {skill1, skill2};
        }

        public Skill GetSkill(int id)
        {
            Skill skill = new Skill { Id = id };
            if (id == 1)
            {
                skill.Name = "Punniken";
            }
            else if (id == 2)
            {
                skill.Name = "Fierljeppen";
            }
            else
            {
                skill.Name = "<undefined>";
            }

            return skill;
        }
    }
}