using System.Collections.Generic;

namespace Ludio.Services.Content
{
    public class TutorialSummaryService
    {
        public IEnumerable<TutorialSummary> GetTutorialSummaries()
        {
            var tutorialSummary = new TutorialSummary
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