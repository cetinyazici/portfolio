using DToLayer.ProfileDtos;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.AdminAccount
{
    public class _ChangePassword : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new ChangePasswordDTO());
        }
    }
}
