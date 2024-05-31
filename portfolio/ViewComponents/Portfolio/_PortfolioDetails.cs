using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using portfolio.Models;

namespace portfolio.ViewComponents.Portfolio
{
    public class _PortfolioDetails : ViewComponent
    {
        private readonly IPortfolioService _portfolioService;
        private readonly IPortfolioDetailsService _portfolioDetailsService;

        public _PortfolioDetails(IPortfolioService portfolioService, IPortfolioDetailsService portfolioDetailsService)
        {
            _portfolioService = portfolioService;
            _portfolioDetailsService = portfolioDetailsService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var portfolio = _portfolioService.TGetByID(id);
            var portfolioDetail = _portfolioDetailsService.TGetByID(id);

            var model = new PortfolioDetailsViewModel
            {
                Portfolio = portfolio,
                PortfolioDetails = portfolioDetail
            };
            return View(model);
        }
    }
}
