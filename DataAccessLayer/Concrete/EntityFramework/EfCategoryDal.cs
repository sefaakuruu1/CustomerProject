﻿using Core.DataAccess;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Kategori,NorthwindContext>,ICategoryDal
    {
     
    }
}
