using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.InMemory
{
   public class InMemoryProductDal : IProductDal
    {
        List<Urun> _urunler;  
        public InMemoryProductDal()
        {
            _urunler = new List<Urun>
            {
                new Urun{KategoriID=1,/*BirimFiyati=10,BirimdekiMiktar=2*/UrunAdi="Bardak",UrunID=1},
                new Urun{KategoriID=2,/*BirimFiyati=15,BirimdekiMiktar=3,*/UrunAdi="Fare",UrunID=2},
                new Urun{KategoriID=3,/*BirimFiyati=100,BirimdekiMiktar=16,*/UrunAdi="Klavye",UrunID=3},
                new Urun{KategoriID=4,/*BirimFiyati=500,BirimdekiMiktar=14,*/UrunAdi="Monitor",UrunID=4},
                new Urun{KategoriID=5,/*BirimFiyati=50,BirimdekiMiktar=12,*/UrunAdi="Hoparlor",UrunID=5}
            };
        }
        public void Add(Urun urun)
        {
            _urunler.Add(urun);

        }

        public void Delete(Urun urun)
        {
            Urun DeletedProduct = _urunler.SingleOrDefault(u => u.UrunID == urun.UrunID);
            _urunler.Remove(DeletedProduct);
        }

        public Urun Get(Expression<Func<Urun, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Urun> GetAll()
        {
            return _urunler;
        }

        public List<Urun> GetAll(Expression<Func<Urun, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Urun> GetCategoryId(int KategoriID)
        {
            return _urunler.Where(p => p.KategoriID == KategoriID).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Urun urun)
        {
            Urun UpdatedProduct = _urunler.SingleOrDefault(p => p.UrunID == urun.UrunID);
            UpdatedProduct.UrunID = urun.UrunID;
            UpdatedProduct.UrunAdi = urun.UrunAdi;
          /*  UpdatedProduct.BirimdekiMiktar = urun.BirimdekiMiktar;
            UpdatedProduct.BirimFiyati = urun.BirimFiyati;  */
        }
    }
}
