using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNewFunction2.Models.Entities.Education;
using TestNewFunction2.Models.Entities.MySkills;
using TestNewFunction2.Models.ProjectDBContex;

namespace TestNewFunction2.Application.Services.Interface
{
    internal interface IMySkillsService
    {
        Task<List<MySkills>> GetListOfMySkills();
        Task<MySkills> CreateMySkills(MySkills mySkills);
        Task<MySkills> DeleteMySkills(int mySkillsId);

    }
}
