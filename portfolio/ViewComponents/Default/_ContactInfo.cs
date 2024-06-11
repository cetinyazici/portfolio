using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.Default
{
    public class _ContactInfo : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
