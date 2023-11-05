using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNewFunction2.Application.Services.Interface;
using TestNewFunction2.Models.Entities.Education;
using TestNewFunction2.Models.ProjectDBContex;

namespace TestNewFunction2.Application.Services.Implementation
{
    public class EducationService:IEducationService 
    {
        #region Dependence Injection
        
        private ProjectDBContex _contex;

        public EducationService(ProjectDBContex contex)
        {
            _contex = contex;
        }

        #endregion

        #region GetListOfEducations
        public async Task<List<Education>> GetListOfEducations()
        {
            //Get a Education
            List<Education> educations = await _contex.Education.ToListAsync(); 
            return educations;
        }

        #endregion

    }
}
