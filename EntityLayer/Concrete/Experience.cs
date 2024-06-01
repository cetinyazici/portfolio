using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string? Position { get; set; }
        public string? Company { get; set; }
        public int StartYear { get; set; }
        public int? EndYear { get; set; }  
        public string? Description { get; set; }
    }
}
