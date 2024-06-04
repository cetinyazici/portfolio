using DToLayer.ProfileDtos;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.AdminAccount
{
    public class _ProfileEdit : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new UserInformationDTO());
        }
    }
}
