using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TestNewFunction2.Models.Entities.Experience
{

    public class Experience
    {
        [Key]
        public int Id { get; set; }
        public string ExprienceTitle { get; set; }
        public string ExprienceDuration { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string Url { get; set; }
    }
}
