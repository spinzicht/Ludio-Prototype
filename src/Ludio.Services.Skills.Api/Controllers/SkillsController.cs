using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ludio.Services.Skills.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        // GET /api/skills/1
        [HttpGet("{id}")]
        public ActionResult<Skill> Get(int id)
        {
            Skill skill = new Skill {Id = id};
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