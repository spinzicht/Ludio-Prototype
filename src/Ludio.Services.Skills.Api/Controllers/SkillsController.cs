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
        // TODO: inject all the things
        ISkillsService _skillsService = new SkillsService();
        
        // GET api/skills
        [HttpGet]
        public ActionResult<IEnumerable<Skill>> Get()
        {
            return _skillsService.GetSkills().ToList();
        }

        // GET api/skills/1
        [HttpGet("{id}")]
        public ActionResult<Skill> Get(int id)
        {
            return _skillsService.GetSkill(id);
        }


    }
}