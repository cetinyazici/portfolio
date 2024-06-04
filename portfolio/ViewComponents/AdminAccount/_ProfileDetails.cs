using BusinessLayer.Abstract;
using DToLayer.ProfileDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.AdminAccount
{
    public class _ProfileDetails : ViewComponent
    {
        public IViewComponentResult Invoke(UserInformationDTO model)
        {
            return View(model);
        }
    }
}
