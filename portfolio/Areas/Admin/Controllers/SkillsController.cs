using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Skills")]
    public class SkillsController : Controller
    {
        private readonly ISkillsService _skillsService;

        public SkillsController(ISkillsService skillsService)
        {
            _skillsService = skillsService;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var values = _skillsService.TGetList();
            return View(values);
        }

        [HttpGet]
        [Route("AddSkills")]
        public IActionResult AddSkills()
        {
            return View();
        }

        [HttpPost]
        [Route("AddSkills")]
        [ValidateAntiForgeryToken]
        public IActionResult AddSkills(Skills skills)
        {
            _skillsService.TInsert(skills);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("UpdateSkills/{id}")]
        public IActionResult UpdateSkills(int id)
        {
            var values = _skillsService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        [Route("UpdateSkills/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateSkills(Skills skills)
        {
            _skillsService.TUpdate(skills);
            return RedirectToAction("Index");
        }

        [Route("DeleteSkills/{id}")]
        public IActionResult DeleteSkills(int id)
        {
            var values = _skillsService.TGetByID(id);
            _skillsService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
