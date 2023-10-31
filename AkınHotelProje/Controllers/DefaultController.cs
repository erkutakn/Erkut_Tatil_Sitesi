using Microsoft.AspNetCore.Mvc;

namespace AkınHotelProje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
