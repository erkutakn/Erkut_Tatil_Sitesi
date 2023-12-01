using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AkınTurizm.ViewComponents.MemberDashboard
{
    public class _PlatformSetting:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
