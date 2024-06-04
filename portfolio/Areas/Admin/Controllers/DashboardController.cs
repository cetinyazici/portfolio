using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace portfolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    [Route("Admin/Dashboard")]
    public class DashboardController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
