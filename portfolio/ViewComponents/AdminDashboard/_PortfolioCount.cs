using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.AdminDashboard
{
    public class _PortfolioCount : ViewComponent
    {
        private readonly IPortfolioService _portfolioService;

        public _PortfolioCount(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _portfolioService.TGetList();
            return View(values);
        }
    }
}
