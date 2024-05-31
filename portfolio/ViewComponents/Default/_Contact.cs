using AutoMapper;
using BusinessLayer.Abstract;
using DToLayer.ContactDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.Default
{
    public class _Contact : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
