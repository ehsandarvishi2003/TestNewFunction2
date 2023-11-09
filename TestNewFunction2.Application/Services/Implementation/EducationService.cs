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
    public class EducationService : IEducationService
    {
        #region Dependence Injection
        
        private readonly ProjectDBContex _contex;

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

        #region CreateEducation
        public async Task<Education> CreateEducation(Education education)
        {
            //Impliment
            education.EducationDuration = "2020-2022";
            education.EducationTitle = "Militery";
            education.Description = "Is not bad at all";
            //Add data to data base and save changes
            await _contex.Education.AddAsync(education);
            await _contex.SaveChangesAsync();

            return education;
        }
        #endregion

        #region DeleteAnEducation
        public async Task<Education> DeleteAnEducation(int educatinId)
        {
            //Make instance with Id==educationId
            Education? education=await _contex.Education.FirstOrDefaultAsync(p=>p.Id == educatinId);
            //Remove 
            _contex.Education.Remove(education);
            await _contex.SaveChangesAsync();
            //return for not getting Error :|
            return education;
        }
        #endregion

    }
}
