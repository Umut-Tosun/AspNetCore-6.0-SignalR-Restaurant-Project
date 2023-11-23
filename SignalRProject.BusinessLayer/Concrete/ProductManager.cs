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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Tadd(Product entity)
        {
            _productDal.add(entity);
        }

        public void Tdelete(Product entity)
        {
            _productDal.update(entity); 
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> TGetListAll()
        {
            return _productDal.GetListAll();
        }

        public List<Product> TProductsWithCategories()
        {
            return _productDal.ProductsWithCategories();
        }

        public void Tupdate(Product entity)
        {
            _productDal.update(entity);
        }
    }
}
