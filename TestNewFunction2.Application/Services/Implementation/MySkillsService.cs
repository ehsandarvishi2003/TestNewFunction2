using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNewFunction2.Application.Services.Interface;
using TestNewFunction2.Models.Entities.Education;
using TestNewFunction2.Models.Entities.MySkills;
using TestNewFunction2.Models.ProjectDBContex;

namespace TestNewFunction2.Application.Services.Implementation
{
    internal class MySkillsService : IMySkillsService
    {
        #region Dependence Injection

        private readonly ProjectDBContex _contex;

        public MySkillsService(ProjectDBContex contex)
        {
            _contex = contex;
        }

        #endregion

        #region GetListOfMySkills
        public async Task<List<MySkills>> GetListOfMySkills()
        {
            List<MySkills> mySkills = await _contex.MySkills.ToListAsync();

            return mySkills;
        }

        #endregion

        #region CreateMySkills
        public async Task<MySkills> CreateMySkills(MySkills mySkills)
        {
            mySkills.SkillTitle = "Runnig";
            mySkills.Percent = 100;

            await _contex.MySkills.AddAsync(mySkills);
            await _contex.SaveChangesAsync();

            return mySkills;
        }

        #endregion

        #region DeleteMySkills
        public async Task<MySkills> DeleteMySkills(int mySkillsId)
        {
            MySkills? mySkills= await _contex.MySkills.FirstOrDefaultAsync(p => p.Id == mySkillsId);

            _contex.MySkills.Remove(mySkills);
            await _contex.SaveChangesAsync();

            return mySkills;
        }

        #endregion
    }
}
