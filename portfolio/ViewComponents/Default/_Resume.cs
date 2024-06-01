using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using portfolio.Models;

namespace portfolio.ViewComponents.Default
{
    public class _Resume : ViewComponent
    {
        private readonly ISummaryService _summaryService;
        private readonly IExperienceService _experienceService;
        private readonly IEducationService _educationService;
        public _Resume(ISummaryService summaryService, IExperienceService experienceService, IEducationService educationService)
        {
            _summaryService = summaryService;
            _experienceService = experienceService;
            _educationService = educationService;
        }

        public IViewComponentResult Invoke()
        {
            var summary = _summaryService.TGetList().FirstOrDefault();
            var experiences = _experienceService.TGetList();
            var educations = _educationService.TGetList();

            var model = new ResumeViewModel
            {
                Summary = summary ?? new Summary(), // Null ise boş bir Summary nesnesi oluştur
                Experiences = experiences ?? new List<Experience>(),
                Educations = educations ?? new List<Education>()
            };
            return View(model);
        }
    }
}
