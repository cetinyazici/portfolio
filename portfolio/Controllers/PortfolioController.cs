using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using portfolio.Models;

namespace portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IActionResult PortfolioDetail(int id)
        {
            return View(id);
        }
    }
}
