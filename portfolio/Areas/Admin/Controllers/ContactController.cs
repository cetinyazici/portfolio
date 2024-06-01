using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("/Admin/Contact")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var values = _contactService.TGetList();
            return View(values);
        }

        [HttpPost]
        [Route("UpdateMessageStatus/{contactId}")]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateMessageStatus(int contactId)
        {
            var contact = _contactService.TGetByID(contactId);
            if (contact != null)
            {
                contact.MessageStatus = !contact.MessageStatus;
                _contactService.TUpdate(contact);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
