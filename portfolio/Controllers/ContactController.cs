using AutoMapper;
using BusinessLayer.Abstract;
using DToLayer.ContactDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;
        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(SendMessageDto model)
        {
            if (ModelState.IsValid)
            {
                var contactEntity = _mapper.Map<Contact>(model);
                contactEntity.MessageDate = DateTime.Now;
                contactEntity.MessageStatus = true;
                _contactService.TInsert(contactEntity);
                return RedirectToAction("Index", "Default");
            }
            return View(model);
        }
    }
}
