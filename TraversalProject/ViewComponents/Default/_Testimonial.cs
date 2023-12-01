using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AkınTurizm.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var testimonials = testimonialManager.TGetList();
            return View(testimonials);
        }
    }
}
