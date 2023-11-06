using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestNewFunction2.Models.Entities.Education;
using TestNewFunction2.Models.ProjectDBContex;

namespace TestNewFunction2.Controllers
{
    
    public class EducationController : Controller
    {
        #region Dependence Injection
        //Dependence Injection
        public EducationController()
        {
        }
        #endregion

        #region listOfEducations
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        } 
        public async Task <IActionResult> ListOfEducatins()
        {
            return View();
        }
        #endregion

        #region CreateAnEducation
        public async Task<IActionResult> CreateAnEducation()
        {
            return RedirectToAction(nameof(ListOfEducatins));
        }
        #endregion

        #region DeleteAnEducation 

        public async Task<IActionResult> DeleteAnEducation(int educationId)
        {
            return RedirectToAction(nameof(ListOfEducatins));
        }

        #endregion

    }
}
  