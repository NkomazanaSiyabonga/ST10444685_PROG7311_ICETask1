using CurriculumVitae.Models;
using System.Collections.Generic;

namespace CurriculumVitae.Models
{
    public class CvViewModel
    {
        // Header
        public string FullName { get; set; }
        public string ProfessionalTitle { get; set; }
        public string ProfileImageUrl { get; set; }

        // About
        public string AboutMe { get; set; }

        // Skills
        public List<string> ProgrammingLanguages { get; set; }
        public List<string> Frameworks { get; set; }
        public List<string> Tools { get; set; }
        public List<string> SoftSkills { get; set; }

        // Projects
        public List<Project> Projects { get; set; }

        // Education
        public List<Education> EducationList { get; set; }

        // Experience
        public List<Experience> ExperienceList { get; set; }

        // Contact
        public string Email { get; set; }
        public string LinkedInUrl { get; set; }
        public string GitHubUrl { get; set; }

        public string References { get; set; }
    }
}