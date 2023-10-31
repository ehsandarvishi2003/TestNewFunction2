using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TestNewFunction2.Models.Entities.MySkills
{
    
    public class MySkills
    {
        [Key]
        public int Id { get; set; }
        public string SkillTitle { get; set; }
        public int Percent { get; set; }
    }
}
