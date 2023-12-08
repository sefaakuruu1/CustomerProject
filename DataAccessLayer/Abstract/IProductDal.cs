using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.DTOs;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal :IEntityRepository<Urun>
    {
        List<ProductDetailDto> GetProductDetails();
     
    }
}
