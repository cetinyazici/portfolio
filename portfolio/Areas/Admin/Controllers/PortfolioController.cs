using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace portfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Portfolio")]
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var values = _portfolioService.TGetList();
            return View(values);
        }

        [Route("UpdatePortfolio/{id}")]
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var values = _portfolioService.TGetByID(id);
            return View(values);
        }

        [Route("UpdatePortfolio/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            _portfolioService.TUpdate(portfolio);
            return RedirectToAction("Index");
        }

        [Route("DeletePortfolio/{id}")]
        public IActionResult DeletePortfolio(int id)
        {
            var values = _portfolioService.TGetByID(id);
            _portfolioService.TDelete(values);
            return RedirectToAction("Index");
        }

        [Route("AddPortfolio")]
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }

        [Route("AddPortfolio")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            _portfolioService.TInsert(portfolio);
            return RedirectToAction("Index");
        }
    }
}
