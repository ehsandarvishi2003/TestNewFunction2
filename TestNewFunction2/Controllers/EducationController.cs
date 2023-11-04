using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestNewFunction2.Models.Entities.Education;
using TestNewFunction2.Models.ProjectDBContex;

namespace TestNewFunction2.Controllers
{
    
    public class EducationController : Controller
    {
        #region listOfEducations
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        } 

        private ProjectDBContex _contex;

        public EducationController(ProjectDBContex contex)
        {
            _contex = contex;
        }

        public async Task <IActionResult> ListOfEducatins()
        {
            List<Education>educations=await _contex.Education.ToListAsync();

            return View();
        }
        #endregion

        #region CreateAnEducation
        public async Task<IActionResult> CreateAnEducation()
        {

            Education educationDataBase = new Education();

            educationDataBase.EducationDuration = "2020-2022";
            educationDataBase.EducationTitle = "Militery";
            educationDataBase.Description = "Is not bad at all";

            await _contex.Education.AddAsync(educationDataBase);
            await _contex.SaveChangesAsync();

            return RedirectToAction(nameof(ListOfEducatins));

        }
        #endregion

        #region DeleteAnEducation 

        public async Task<IActionResult> DeleteAnEducation()
        {
            Education? education1 = await _contex.Education.FirstOrDefaultAsync(p => p.Id == 1);

            _contex.Education.Remove(education1);
            await _contex.SaveChangesAsync();

            return RedirectToAction(nameof(ListOfEducatins));
        }

        #endregion

    }
}
