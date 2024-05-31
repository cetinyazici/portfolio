using Microsoft.AspNetCore.Mvc;

namespace portfolio.ViewComponents.Default
{
    public class _Testimonials : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
