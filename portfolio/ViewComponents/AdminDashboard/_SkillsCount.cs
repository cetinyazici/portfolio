using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.AdminDashboard
{
    public class _SkillsCount : ViewComponent
    {
        private readonly ISkillsService _skillsService;

        public _SkillsCount(ISkillsService skillsService)
        {
            _skillsService = skillsService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _skillsService.TGetList();
            return View(values);
        }
    }
}
