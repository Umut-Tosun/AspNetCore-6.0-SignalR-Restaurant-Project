using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void add(T entity);
        void delete(T entity);
        void update(T entity);
        T GetById(int id);
        List<T> GetListAll();

    }
}
