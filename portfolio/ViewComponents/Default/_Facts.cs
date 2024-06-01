using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using portfolio.Models;

namespace portfolio.ViewComponents.Default
{
    public class _Facts : ViewComponent
    {
        private readonly IPortfolioService _portfolioService;
        private readonly IServicesService _servicesService;
        private readonly ISkillsService _skillsService;

        public _Facts(IPortfolioService portfolioService, IServicesService servicesService, ISkillsService skillsService)
        {
            _portfolioService = portfolioService;
            _servicesService = servicesService;
            _skillsService = skillsService;
        }

        public IViewComponentResult Invoke()
        {
            var portfolios = _portfolioService.TGetList();
            var skills = _skillsService.TGetList();
            var services = _servicesService.TGetList();

            var model = new FactsViewModel()
            {
                Services = services,
                Skills = skills,
                Portfolio = portfolios,
            };
            return View(model);
        }
    }
}
