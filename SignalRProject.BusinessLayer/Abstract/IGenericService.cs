using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Tadd(T entity);
        void Tdelete(T entity);
        void Tupdate(T entity);
        T TGetById(int id);
        List<T> TGetListAll();
    }
}
