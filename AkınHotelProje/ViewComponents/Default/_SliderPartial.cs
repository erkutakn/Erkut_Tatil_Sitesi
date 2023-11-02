using Microsoft.AspNetCore.Mvc;

namespace AkınTurizmProje.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
