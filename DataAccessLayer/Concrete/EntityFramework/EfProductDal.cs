using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Concrete;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.DataAccess;
using Entities.DTOs;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Urun, NorthwindContext>, IProductDal
    {//IProductDal ın da implemente edilmesinin sebebi sadece o sınıfa ozgu olan metodları kullanabşlmektir
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Urunler
                             join c in context.Kategoriler
                             on p.KategoriID equals c.KategoriID
                             select new ProductDetailDto { UrunID = p.UrunID, UrunAdi = p.UrunAdi,
                                 KategoriAdi = c.KategoriAdi, BirimdekiMiktar = p.BirimdekiMiktar
                             };
                return result.ToList();
            }
        }
    }
}
