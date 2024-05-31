using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.Default
{
    public class _Services : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
