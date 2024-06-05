using DToLayer.ProfileDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.AdminAccount
{
    public class _ProfileEdit : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileEdit(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync((System.Security.Claims.ClaimsPrincipal)User);
            if (user == null)
            {
                return Content("User not found");
            }

            var model = new UserInformationDTO
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Gender = user.Gender,
                ImageUrl = user.ImageUrl
            };

            return View(model);
        }
    }
}
