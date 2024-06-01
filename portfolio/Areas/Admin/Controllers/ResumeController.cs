using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using portfolio.Models;

namespace portfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Resume")]
    public class ResumeController : Controller
    {
        private readonly ISummaryService _summaryService;
        private readonly IExperienceService _experienceService;
        private readonly IEducationService _educationService;
        public ResumeController(ISummaryService summaryService, IExperienceService experienceService, IEducationService educationService)
        {
            _summaryService = summaryService;
            _experienceService = experienceService;
            _educationService = educationService;
        }

        [Route("Index")]
        public IActionResult Index()
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

        [HttpGet]
        [Route("UpdateResumeSummary/{id}")]
        public IActionResult UpdateResumeSummary(int id)
        {
            var values = _summaryService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        [Route("UpdateResumeSummary/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateResumeSummary(Education education)
        {
            _educationService.TUpdate(education);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("UpdateResumeEducation/{id}")]
        public IActionResult UpdateResumeEducation(int id)
        {
            var values = _educationService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        [Route("UpdateResumeEducation/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateResumeEducation(Education education)
        {
            _educationService.TUpdate(education);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("UpdateResumeExperiences/{id}")]
        public IActionResult UpdateResumeExperiences(int id)
        {
            var values = _experienceService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        [Route("UpdateResumeExperiences/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateResumeExperiences(Experience experience)
        {
            _experienceService.TUpdate(experience);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("AddResumeSummary")]
        public IActionResult AddResumeSummary()
        {
            return View();
        }

        [HttpPost]
        [Route("AddResumeSummary")]
        [ValidateAntiForgeryToken]
        public IActionResult AddResumeSummary(Summary summary)
        {
            _summaryService.TInsert(summary);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("AddResumeEducation")]
        public IActionResult AddResumeEducation()
        {
            return View();
        }

        [HttpPost]
        [Route("AddResumeEducation")]
        [ValidateAntiForgeryToken]
        public IActionResult AddResumeEducation(Education education)
        {
            _educationService.TInsert(education);
            return RedirectToAction("Index");
        }


        [HttpGet]
        [Route("AddResumeExperiences")]
        public IActionResult AddResumeExperiences()
        {
            return View();
        }

        [HttpPost]
        [Route("AddResumeExperiences")]
        [ValidateAntiForgeryToken]
        public IActionResult AddResumeExperiences(Experience experience)
        {
            _experienceService.TInsert(experience);
            return RedirectToAction("Index");
        }

        [Route("DeleteResumeSummary/{id}")]
        public IActionResult DeleteResumeSummary(int id)
        {
            var values = _summaryService.TGetByID(id);
            _summaryService.TDelete(values);
            return RedirectToAction("Index");
        }

        [Route("DeleteResumeEducation/{id}")]
        public IActionResult DeleteResumeEducation(int id)
        {
            var values = _educationService.TGetByID(id);
            _educationService.TDelete(values);
            return RedirectToAction("Index");
        }

        [Route("DeleteResumeExperiences/{id}")]
        public IActionResult DeleteResumeExperiences(int id)
        {
            var values = _experienceService.TGetByID(id);
            _experienceService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
