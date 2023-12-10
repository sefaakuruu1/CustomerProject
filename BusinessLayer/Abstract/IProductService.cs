using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IProductService
    {
        IDataResult<List<Urun>> GetAll();
        IResult Add(Urun urun);
        IDataResult<List<Urun>> GetByCategoryId(int KategoriId);
        IResult Update(Urun urun);
        IDataResult<List<Urun>> GetProductDetails();
         
    }
}
