using SignalRProject.BusinessLayer.Abstract;
using SignalRProject.DataAccessLayer.Abstract;
using SignalRProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Tadd(Testimonial entity)
        {
           _testimonialDal.add(entity);
        }

        public void Tdelete(Testimonial entity)
        {
           _testimonialDal.delete(entity);
        }

        public Testimonial TGetById(int id)
        {
           return _testimonialDal.GetById(id);
        }

        public List<Testimonial> TGetListAll()
        {
           return _testimonialDal.GetListAll();
        }

        public void Tupdate(Testimonial entity)
        {
           _testimonialDal.update(entity);
        }
    }
}
