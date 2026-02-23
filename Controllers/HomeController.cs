using Microsoft.AspNetCore.Mvc;
using CurriculumVitae.Models;
using System.Collections.Generic;

namespace CurriculumVitae.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new CvViewModel
            {
                FullName = "Siyabonga Nkomazana",
                ProfessionalTitle = "Final-Year IT Student · Aspiring Software Developer",
                
                AboutMe = "I am a final-year Information Technology student at Emeris with strong skills in software development. My technical experience include developing applications using Java and C# whilst focusing on constructiing clean, efficient and reliable code.",

                ProgrammingLanguages = new List<string> { "C#", "Java", "SQL" },
                Frameworks = new List<string> { "ASP.NET Core MVC", "Entity Framework Core" },
                Tools = new List<string> { "Git", "GitHub", "Visual Studio" },
                SoftSkills = new List<string> { "Teamwork", "Problem-Solving", "Communication", "Time Management" },

                Projects = new List<Project>
                {
                    new Project
                    {
                        Name = "Cybersecurity Awareness Chatbot",
                        Description = "A Console-based C# Chatbot that educates users about cybersecurity best practices in an interactive and engaging way. It responds to user input with advice on topics such as password safety, phishing scams, digital footprints, cyberbullying, and more",
                        LinkedinLink = "C#, ASP.NET Core MVC, Azure Table Storage",
                        GitHubLink = "https://github.com/NkomazanaSiyabonga/ProgPOEPart1"
                    }
                },

                EducationList = new List<Education>
                {
                    new Education
                    {
                        Institution = "Emeris Ruimsig (Formally IIE MSA)",
                        Qualification = "Bachelor in Computer and Information Science",
                        Year = "Expected 2026",
                        Details = "Major modules: Software Development, Web Development, Database Systems."
                    }
                },

                ExperienceList = new List<Experience>
                {
                    new Experience
                    {
                        Company = "Chicken Licken",
                        Role = "Maintenence Work",
                        Duration = "December 2023 - January 2024",
                        Description = "Conducted general maintenence around stores."
                    }
                },

                Email = "siyabonga.s.nkomazana@gmail.com",
                LinkedInUrl = "https://www.linkedin.com/in/siyabonga-nkomazana-a01b9a374 ",
                GitHubUrl = "https://github.com/NkomazanaSiyabonga",

                References = "Available on Request",
            };

            return View(model);
        }
    }
}