using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TestNewFunction2.Models.Entities.Education
{

    public class Education
    {

        [Key]
        public int Id { get; set; }
        
        public string EducationTitle { get; set; }
        public string EducationDuration { get; set; }
        public string Description { get; set; }
    }
}
