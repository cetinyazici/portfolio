using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.Default
{
    public class _Contact : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
