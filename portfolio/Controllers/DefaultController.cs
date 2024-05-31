using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
