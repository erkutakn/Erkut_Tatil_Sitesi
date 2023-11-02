using Microsoft.AspNetCore.Mvc;

namespace AkınTurizmProje.ViewComponents.Default
{
    public class _PopularDestinations:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
