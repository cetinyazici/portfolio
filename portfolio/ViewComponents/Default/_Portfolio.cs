using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.Default
{
    public class _Portfolio : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
