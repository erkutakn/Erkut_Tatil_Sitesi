using Microsoft.AspNetCore.Mvc;

namespace AkınTurizmProje.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
