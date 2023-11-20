using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestiMonialManager:ITestiMonialService
    {
        ITestiMonialDal _testiMonialDal;

        public TestiMonialManager(ITestiMonialDal testiMonialDal)
        {
            _testiMonialDal = testiMonialDal;
        }

        public void TAdd(TestiMonial t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(TestiMonial t)
        {
            throw new NotImplementedException();
        }

        public TestiMonial TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<TestiMonial> TGetList()
        {
            return _testiMonialDal.GetList();
        }

        public void TUpdate(TestiMonial t)
        {
            throw new NotImplementedException();
        }
    }
}
