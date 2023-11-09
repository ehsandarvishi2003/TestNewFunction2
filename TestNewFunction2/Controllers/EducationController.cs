using Microsoft.AspNetCore.Mvc;

namespace TestNewFunction2.Controllers
{

    public class EducationController : Controller
    {
        #region Dependence Injection
        //Dependence Injection
        //private ProjectDBContex ;

        //public EducationController(ProjectDBContex contex)
        //{
        //     = contex;
        //}
        #endregion

        #region listOfEducations
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        } 
        //public async Task <IActionResult> ListOfEducatins()
        //{
            
        //}
        #endregion

        #region CreateAnEducation
        //public async Task<IActionResult> CreateAnEducation()
        //{

            //Education educationDataBase = new Education();

            //educationDataBase.EducationDuration = "2020-2022";
            //educationDataBase.EducationTitle = "Militery";
            //educationDataBase.Description = "Is not bad at all";

            //await _contex.Education.AddAsync(educationDataBase);
            //await _contex.SaveChangesAsync();

            //return RedirectToAction(nameof(ListOfEducatins));

        //}
        #endregion

        #region DeleteAnEducation 
        /*
        public async Task<IActionResult> DeleteAnEducation(int educationId)
        {
            //Education? education1 = await _contex.Education.FirstOrDefaultAsync(p => p.Id == educationId);

            //_contex.Education.Remove(education1);
            //await _contex.SaveChangesAsync();

            //return RedirectToAction(nameof(ListOfEducatins));
        }
        */
        #endregion

    }
}
