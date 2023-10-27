using Microsoft.EntityFrameworkCore;

namespace TestNewFunction2.Models.Entities.Education
{
    [Keyless]
    public class Education
    {
        public int Id { get; set; }
        public string EducationTitle { get; set; }
        public string EducationDuration { get; set; }
        public string Description { get; set; }
    }
}
