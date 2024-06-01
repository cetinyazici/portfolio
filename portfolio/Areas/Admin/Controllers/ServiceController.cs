using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Service")]
    public class ServiceController : Controller
    {
        private readonly IServicesService _servicesService;

        public ServiceController(IServicesService servicesService)
        {
            _servicesService = servicesService;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var values = _servicesService.TGetList();
            return View(values);
        }

        [Route("AddService")]
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }

        [Route("AddService")]
        [HttpPost]
        public IActionResult AddService(Services services)
        {
            _servicesService.TInsert(services);
            return RedirectToAction("Index");
        }

        [Route("UpdateService/{id}")]
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var services = _servicesService.TGetByID(id);
            return View(services);
        }

        [Route("UpdateService/{id}")]
        [HttpPost]
        public IActionResult UpdateService(Services services)
        {
            _servicesService.TUpdate(services);
            return RedirectToAction("Index");
        }

        [Route("DeleteService/{id}")]
        public IActionResult DeleteService(int id)
        {
            var values = _servicesService.TGetByID(id);
            _servicesService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
