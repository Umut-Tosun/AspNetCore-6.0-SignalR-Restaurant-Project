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
    public class ContactManager : IContactService
    {
        void add(T entity);
        void delete(T entity);
        void update(T entity);
        T GetById(int id);
        List<T> GetListAll(); IContactDal _contactDal;
        public void Tadd(Contact entity)
        {
            _contactDal.add(entity);
        }

        public void Tdelete(Contact entity)
        {
            _contactDal.delete(entity);
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> TGetListAll()
        {
            return _contactDal.GetListAll();
        }

        public void Tupdate(Contact entity)
        {
           _contactDal.update(entity);   
        }
    }
}
