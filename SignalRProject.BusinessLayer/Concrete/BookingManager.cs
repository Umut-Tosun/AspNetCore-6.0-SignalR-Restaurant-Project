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
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;
        public void Tadd(Booking entity)
        {
            _bookingDal.add(entity);
        }

        public void Tdelete(Booking entity)
        {
            _bookingDal.delete(entity);
        }

        public Booking TGetById(int id)
        {
           return _bookingDal.GetById(id);
        }

        public List<Booking> TGetListAll()
        {
           return _bookingDal.GetListAll();
        }

        public void Tupdate(Booking entity)
        {
            _bookingDal.update(entity);
        }
    }
}
