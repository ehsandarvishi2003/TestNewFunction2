using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestNewFunction2.Models.Entities.MySkills;

namespace TestNewFunction2.Controllers
{
    public class MySkillsController : Controller
    {
        #region ListOfMySkills

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        

        public async Task<IActionResult> ListOfMySkills()
        {
            

            return View();
        }
        #endregion

        #region CreateMySkills
        public async Task<IActionResult> CreateMySkills()
        {

            

            return RedirectToAction(nameof(ListOfMySkills));

        }

        #endregion

        #region DeleteAnMySkills
        public async Task<IActionResult> DeleteAnMySkills(int mySkillsId)
        {
            

            return RedirectToAction(nameof(ListOfMySkills));
        }
        #endregion

    }
}
