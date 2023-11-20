using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AkınTurizmProje.ViewComponents.Default
{
    public class _TestiMonial : ViewComponent
    {
        TestiMonialManager testiMonialManager = new TestiMonialManager(new EfTestiMonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testiMonialManager.TGetList();
            return View(values);
        }
    }
}
