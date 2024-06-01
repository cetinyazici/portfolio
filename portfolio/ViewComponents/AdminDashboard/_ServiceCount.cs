using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.AdminDashboard
{
    public class _ServiceCount : ViewComponent
    {
        private readonly IServicesService _servicesService;

        public _ServiceCount(IServicesService servicesService)
        {
            _servicesService = servicesService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _servicesService.TGetList();
            return View(values);
        }
    }
}
