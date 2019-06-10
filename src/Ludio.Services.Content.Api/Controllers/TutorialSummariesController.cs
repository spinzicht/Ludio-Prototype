using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ludio.Services.Content.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorialSummariesController : ControllerBase
    {
        // GET api/TutorialSummaries
        [HttpGet]
        public ActionResult<IEnumerable<TutorialSummary>> Get()
        {
            var tutorialSummary = new TutorialSummary()
            {
                Name = "Test tutorial",
                Thumbnail = "smiley.png",
                Author = "Harry",
                Program = "Scratch",
                SkillIds = new[] { 1, 2 }
            };
            
            return new List<TutorialSummary> { tutorialSummary };
        }
    }
}