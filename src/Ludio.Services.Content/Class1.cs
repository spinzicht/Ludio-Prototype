using System;

namespace Ludio.Services.Content
{
    public class Tutorial
    {
        public string Identifier { get; set; }
        public string Name { get; set; }
        Section[] Sections { get; set; }
    }

    public class Section
    {
        private string Identifier { get; set; }
        string SkillIdentifier { get; set; }

        private Step[] Steps { get; set; }

    }

    public class Step
    {
        private string StepType { get; set; }
    }

    public class TutorialSummary
    {
        // Naam
        // Thumbnail
        // Skills { 1, 2, 3 }
        // Author
        // Program (Scratch / ...)
    }
}
