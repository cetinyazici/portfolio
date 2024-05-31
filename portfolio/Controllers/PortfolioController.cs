using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IActionResult PortfolioDetails(int id)
        {
            ViewData["id"] = id;
            return View();
        }
    }
}
