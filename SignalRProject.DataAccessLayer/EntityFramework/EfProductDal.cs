﻿using SignalRProject.DataAccessLayer.Abstract;
using SignalRProject.DataAccessLayer.Concrete;
using SignalRProject.DataAccessLayer.Repositires;
using SignalRProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(Context context) : base(context)
        {
        }
    }
}
