#region Using
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNewFunction2.Models.Entities.Education;
#endregion

namespace TestNewFunction2.Application.Services.Interface
{
    internal interface IEducationService
    {
        Task<List<Education>> GetListOfEducations();
        Task CreateAnEducation(Education education);
        Task DeleteAnEducation(int educationId);
    }
}
