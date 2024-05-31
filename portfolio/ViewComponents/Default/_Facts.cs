using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.Default
{
    public class _Facts : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
