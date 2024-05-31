using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.Default
{
    public class _Resume : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
