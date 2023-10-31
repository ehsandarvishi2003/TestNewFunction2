using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestNewFunction2.Models.Entities.Education;
using TestNewFunction2.Models.Entities.MySkills;
using TestNewFunction2.Models.ProjectDBContex;

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

        private ProjectDBContex _contex;

        public MySkillsController(ProjectDBContex contex)
        {
            _contex = contex;
        }

        public async Task<IActionResult> ListOfMySkills()
        {
            List<MySkills> mySkills = await _contex.MySkills.ToListAsync();

            return View();
        }
        #endregion

        #region CreateAnMySkills
        public async Task<IActionResult> CreateAnMySkills()
        {

            MySkills MySkillsDataBase = new MySkills();

            MySkillsDataBase.SkillTitle = "Runnig";
            MySkillsDataBase.Percent = 100;
            

            await _contex.MySkills.AddAsync(MySkillsDataBase);
            await _contex.SaveChangesAsync();

            return RedirectToAction(nameof(ListOfMySkills));

        }

        #endregion

        #region DeleteAnMySkills
        public async Task<IActionResult> DeleteAnMySkills()
        {
            MySkills? mySkills1 = await _contex.MySkills.FirstOrDefaultAsync(p => p.Id == 1);

            _contex.MySkills.Remove(mySkills1);
            await _contex.SaveChangesAsync();

            return RedirectToAction(nameof(ListOfMySkills));
        }
        #endregion

    }
}
