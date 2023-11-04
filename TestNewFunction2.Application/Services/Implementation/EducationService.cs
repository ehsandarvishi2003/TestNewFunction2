using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNewFunction2.Application.Services.Interface;
using TestNewFunction2.Models.ProjectDBContex;

namespace TestNewFunction2.Application.Services.Implementation
{
    public class EducationService:IEducationService 
    {
        #region Dependence Injection
        //Dependence Injection
        private ProjectDBContex _contex;

        public EducationService(ProjectDBContex contex)
        {
            _contex = contex;
        }
        #endregion

    }
}
