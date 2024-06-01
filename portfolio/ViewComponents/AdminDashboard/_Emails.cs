using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.AdminDashboard
{
    public class _Emails : ViewComponent
    {
        private readonly IContactService _contactService;

        public _Emails(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactService.TGetList();
            return View(values);
        }
    }
}
