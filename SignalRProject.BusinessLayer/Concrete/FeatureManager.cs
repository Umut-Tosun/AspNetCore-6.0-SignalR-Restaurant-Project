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
    public class FeatureManager : IGenericService<Feature>
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Tadd(Feature entity)
        {
           _featureDal.add(entity);
        }

        public void Tdelete(Feature entity)
        {
            _featureDal.delete(entity);
        }

        public Feature TGetById(int id)
        {
           return _featureDal.GetById(id);
        }

        public List<Feature> TGetListAll()
        {
            return _featureDal.GetListAll();
        }

        public void Tupdate(Feature entity)
        {
            _featureDal.update(entity);
        }
    }
}
