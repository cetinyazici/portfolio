using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(string code)
        {
            return View();
        }
    }
}
