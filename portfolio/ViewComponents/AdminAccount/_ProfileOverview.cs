using DToLayer.ProfileDtos;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.AdminAccount
{
    public class _ProfileOverview : ViewComponent
    {
        public IViewComponentResult Invoke(UserInformationDTO model)
        {
            return View(model);
        }
    }
}
