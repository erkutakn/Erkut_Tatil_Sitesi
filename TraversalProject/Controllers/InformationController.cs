using Microsoft.AspNetCore.Mvc;

namespace AkınTurizm.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
