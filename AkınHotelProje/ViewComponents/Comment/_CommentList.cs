using Microsoft.AspNetCore.Mvc;

namespace AkınTurizmProje.ViewComponents.Comment
{
    public class _CommentList: ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
