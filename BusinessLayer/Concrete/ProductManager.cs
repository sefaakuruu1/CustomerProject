using BusinessLayer.Abstract;
using Core.Utilities;
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

        public IDataResult<List<Urun>> GetAll()
        {
            if (DateTime.Now.Hour == 3)
            {
                return new ErrorDataResult<List<Urun>>(_productDal.GetAll(),Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Urun>>(_productDal.GetAll(),Messages.ProductListed);
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

        IResult IProductService.Add(Urun urun)
        {
            _productDal.Add(urun);
            return new Result(Messages.ProductAdded,true);
        }

        IResult IProductService.Update(Urun urun)
        {
            _productDal.Update(urun);
            if (urun.UrunAdi.Length > 4)
            {
                return new ErrorResult(Messages.ProductAddedError);
            }
            
            return new SuccessResult(Messages.ProductAdded);
        }
    }
}
