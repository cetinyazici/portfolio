using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.AdminDashboard
{
    public class _SkillList : ViewComponent
    {
        private readonly ISkillsService _skillsService;

        public _SkillList(ISkillsService skillsService)
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
