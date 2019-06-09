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
        // GET: api/TutorialSummaries
        [HttpGet]
        public IEnumerable<TutorialSummary> Get()
        {
            return new List<TutorialSummary>();
        }
    }
}