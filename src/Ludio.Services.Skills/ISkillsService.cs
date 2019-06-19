using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Ludio.Services.Skills
{
    public interface ISkillsService
    {
        IEnumerable<Skill> GetSkills();
        Skill GetSkill(int id);
    }
}