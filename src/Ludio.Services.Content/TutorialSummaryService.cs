using System.Collections.Generic;

namespace Ludio.Services.Content
{
    public class TutorialSummaryService
    {
        public IEnumerable<TutorialSummary> GetTutorialSummaries()
        {
            var tutorialSummary1 = new TutorialSummary
            {
                Name = "Highway Traffic",
                Thumbnail = "thumb.png",
                Author = "Harry",
                Program = "Scratch",
                SkillIds = new[] {1, 2, 3, 4, 5, 6}
            };

            var tutorialSummary2 = new TutorialSummary
            {
                Name = "Shark Attack",
                Thumbnail = "thumb.png",
                Author = "Harry",
                Program = "Scratch",
                SkillIds = new[] {1, 4, 6}
            };

            return new List<TutorialSummary> { tutorialSummary1, tutorialSummary2 };
        }
    }
}