using Microsoft.EntityFrameworkCore;

namespace TestNewFunction2.Models.Entities.MySkills
{
    [Keyless]
    public class MySkills
    {
        public int Id { get; set; }
        public string SkillTitle { get; set; }
        public int Percent { get; set; }
    }
}
