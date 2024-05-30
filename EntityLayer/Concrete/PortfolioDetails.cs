using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PortfolioDetails
    {
        [Key]
        public int PortfolioDetailsId { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? ProjectName { get; set; }
        public string? ProjectUrl { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
