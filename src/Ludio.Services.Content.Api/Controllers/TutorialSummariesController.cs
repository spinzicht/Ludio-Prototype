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
        // TODO: inject
        readonly TutorialSummaryService _tutorialSummaryService = new TutorialSummaryService();
        
        // GET api/TutorialSummaries
        [HttpGet]
        public ActionResult<IEnumerable<TutorialSummary>> Get()
        {
            return _tutorialSummaryService.GetTutorialSummaries().ToList();
        }
    }
}