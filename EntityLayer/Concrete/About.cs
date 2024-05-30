using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        public string? Description1 { get; set; }
        public string? Description2 { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Mail { get; set; }
        public string? Phone { get; set; }
        public string? LinkedinUrl { get; set; }
        public string? GithubUrl { get; set; }
    }
}
