using Microsoft.AspNetCore.Mvc;

namespace AkınTurizmProje.ViewComponents.Comment
{
    public class _AddComment:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
