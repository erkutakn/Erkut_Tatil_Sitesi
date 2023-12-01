using Microsoft.AspNetCore.Mvc;

namespace AkınTurizm.ViewComponents.MemberLayout
{
    public class _MemberLayoutLanguages : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
