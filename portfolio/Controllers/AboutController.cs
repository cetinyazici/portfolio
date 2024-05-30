using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
