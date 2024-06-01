using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.Default
{
    public class _Skills : ViewComponent
    {
        private readonly ISkillsService _skillsService;

        public _Skills(ISkillsService skillsService)
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
