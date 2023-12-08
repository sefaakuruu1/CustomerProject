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
        List<Urun> GetAll();
        void Add(Urun urun);
        List<Urun> GetByCategoryId(int KategoriId);
        void Update(Urun urun);
        List<ProductDetailDto> GetProductDetails();
         
    }
}
