using BusinessLayer.Abstract;
using DToLayer.ProfileDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IAppUserService _appUserService;

        public UserController(UserManager<AppUser> userManager, IAppUserService appUserService)
        {
            _userManager = userManager;
            _appUserService = appUserService;
        }

        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }

            var model = new ProfileViewModel
            {
                UserInformation = new UserInformationDTO
                {
                    Id = user.Id,
                    ImageUrl = user.ImageUrl,
                    Name = user.Name,
                    Surname = user.Surname,
                    Gender = user.Gender,
                    Email = user.Email
                },
                ChangePassword = new ChangePasswordDTO()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile(UserInformationDTO model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.Id.ToString());
                if (user != null)
                {
                    user.ImageUrl = model.ImageUrl;
                    user.Name = model.Name;
                    user.Surname = model.Surname;
                    user.Gender = model.Gender;
                    user.Email = model.Email;

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Profile");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "User not found");
                }
            }
            var viewModel = new ProfileViewModel
            {
                UserInformation = model,
                ChangePassword = new ChangePasswordDTO()
            };
            return View("Profile", viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordDTO model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                    if (result.Succeeded)
                    {
                        // Kullanıcı şifre değiştirdikten sonra giriş yapmasını sağlamak için oturumu sonlandırıyoruz.
                        await _userManager.UpdateSecurityStampAsync(user);
                        await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);

                        return RedirectToAction("SignIn", "Account");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "User not found");
                }
            }

            var userForView = await _userManager.GetUserAsync(User);

            var viewModel = new ProfileViewModel
            {
                UserInformation = new UserInformationDTO
                {
                    Id = userForView.Id,
                    ImageUrl = userForView.ImageUrl,
                    Name = userForView.Name,
                    Surname = userForView.Surname,
                    Gender = userForView.Gender,
                    Email = userForView.Email
                },
                ChangePassword = model
            };

            return View("Profile", viewModel);
        }


    }
}
