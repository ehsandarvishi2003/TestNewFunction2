using Microsoft.AspNetCore.Mvc;
using TestNewFunction2.Models.Entities.Education;
using TestNewFunction2.Models.ProjectDBContex;

namespace TestNewFunction2.Controllers
{
    
    public class EducationController : Controller
    {
        #region listOfEducations
        public IActionResult Index()
        {
            return View();
        } 

        //ProjectDBContex _contexDB = new ProjectDBContex();

        private ProjectDBContex _contex;

        public EducationController(ProjectDBContex contex)
        {
            _contex = contex;
        }

        public IActionResult ListOfEducatins()
        {
            List<Education>educations=_contex.Education.ToList();

            return View();
        }
        #endregion

        #region CreateAnEducation
        public IActionResult CreateAnEducation()
        {
            List<Education> educasionList = new List<Education>();

            Education education = new Education()
            {
                Id = 1,
                EducationTitle = "Master",
                EducationDuration = "2012",
                Description = "Degree"
            };

            educasionList.Add(education);

            educasionList.Add(new Education()
            {
                Id = 2,
                EducationTitle = "Master",
                EducationDuration = "2012",
                Description = "Degree"
            });

            educasionList.Add(education);
            Education educationDataBase = new Education()
            {
                EducationTitle = "Sepejr",
                EducationDuration="2023",
                Description="Sepehr"
            };

            _contex.Education.Add(education);
            _contex.SaveChanges();

            return View();

        }
        #endregion
    }
}
