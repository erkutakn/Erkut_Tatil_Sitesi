using Microsoft.AspNetCore.Mvc;

namespace AkınTurizmProje.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
