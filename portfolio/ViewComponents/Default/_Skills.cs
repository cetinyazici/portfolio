using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.Default
{
    public class _Skills : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
