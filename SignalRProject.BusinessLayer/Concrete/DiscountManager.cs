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
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public void Tadd(Discount entity)
        {
            _discountDal.add(entity);
        }

        public void Tdelete(Discount entity)
        {
            _discountDal.delete(entity);
        }

        public Discount TGetById(int id)
        {
           return _discountDal.GetById(id);
        }

        public List<Discount> TGetListAll()
        {
            return _discountDal.GetListAll();
        }

        public void Tupdate(Discount entity)
        {
           _discountDal.update(entity);
        }
    }
}
