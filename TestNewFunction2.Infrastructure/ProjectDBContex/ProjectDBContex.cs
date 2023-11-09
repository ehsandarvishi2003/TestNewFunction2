using Microsoft.EntityFrameworkCore;
using TestNewFunction2.Models.Entities.Education;
using TestNewFunction2.Models.Entities.Experience;
using TestNewFunction2.Models.Entities.MySkills;

namespace TestNewFunction2.Models.ProjectDBContex
{
    public class ProjectDBContex:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=EHSAN;Initial Catalog=TestDbConnetion;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Education> Education { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<MySkills> MySkills { get; set; }
    }
}
