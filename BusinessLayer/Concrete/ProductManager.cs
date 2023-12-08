using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Urun urun)
        {
            _productDal.Add(urun);
        }

        public List<Urun> GetAll()
        {
           return _productDal.GetAll();
        }

        public List<Urun> GetByCategoryId(int KategoriId)
        {
            return _productDal.GetAll(p => p.KategoriID == KategoriId);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        public void Update(Urun urun)
        {
            _productDal.Update(urun);
        }
    }
}
