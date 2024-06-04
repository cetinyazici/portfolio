using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    [Route("Admin/Testimonial")]
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var values = _testimonialService.TGetList();
            return View(values);
        }

        [HttpGet]
        [Route("AddTestimonial")]
        public IActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        [Route("AddTestimonial")]
        [ValidateAntiForgeryToken]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialService.TInsert(testimonial);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("UpdateTestimonial/{id}")]
        public IActionResult UpdateTestimonial(int id)
        {
            var services = _testimonialService.TGetByID(id);
            return View(services);
        }

        [HttpPost]
        [Route("UpdateTestimonial/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonialService.TUpdate(testimonial);
            return RedirectToAction("Index");
        }

        [Route("DeleteTestimonial/{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
