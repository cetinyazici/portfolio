using EntityLayer.Concrete;

namespace portfolio.Models
{
    public class ResumeViewModel
    {
        public Summary Summary { get; set; }
        public List<Education> Educations { get; set; }
        public List<Experience> Experiences { get; set; }
    }
}
