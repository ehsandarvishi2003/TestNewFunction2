using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using TestNewFunction2.Application.Services.Interface;
using TestNewFunction2.Models.Entities.Education;
using TestNewFunction2.Models.ProjectDBContex;

namespace TestNewFunction2.Application.Services.Implementation
{
    public class EducationService : IEducationService 
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

        #region CreateAnEducation
        public async Task CreateAnEducation(Education education)
        {
            #region Fill Education Instance 

            education.EducationDuration = "2020-2022";
            education.EducationTitle = "Militery";
            education.Description = "Is not bad at all";

            #endregion

            #region Add Record to The Data Base

            await _contex.Education.AddAsync(education);
            await _contex.SaveChangesAsync();

            #endregion
        }
        #endregion

        #region DeleteAnEducation
        public async Task DeleteAnEducation(int educationId)
        {
            #region Find Record

            Education education =await GetAnEducationById(educationId);

            #endregion

            #region Delete Record and save change

            _contex.Education.Remove(education);
            await _contex.SaveChangesAsync();

            #endregion
        }
        #endregion

        #region Find Education by Id

        public async Task<Education> GetAnEducationById (int educationId)
        {
            #region Find Record

            Education? education = await _contex.Education.FirstOrDefaultAsync(p => p.Id == educationId);

            #endregion

            //Stupid error handeling
            if (education == null) return null;

            return education;
        }

        #endregion

    }
}
