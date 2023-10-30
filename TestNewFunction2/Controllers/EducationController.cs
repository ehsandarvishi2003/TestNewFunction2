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
            
            Education educationDataBase = new Education()
            {
                EducationTitle = "Sepejr",
                EducationDuration="2023",
                Description="Sepehr"
            };

            _contex.Education.Add(educationDataBase);
            _contex.SaveChanges();

            return View();

        }
        #endregion
    }
}
