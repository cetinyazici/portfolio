using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/About")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var values = _aboutService.TGetList();
            return View(values);
        }

        [Route("UpdateAbout/{id}")]
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = _aboutService.TGetByID(id);
            return View(values);
        }

        [Route("UpdateAbout/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateAbout(About about)
        {  _aboutService.TUpdate(about);
            return RedirectToAction("Index");
        }

    }
}
