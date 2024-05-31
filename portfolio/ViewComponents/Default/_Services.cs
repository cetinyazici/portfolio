using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.Default
{
    public class _Services : ViewComponent
    {
        private readonly IServicesService _servicesService;

        public _Services(IServicesService servicesService)
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
