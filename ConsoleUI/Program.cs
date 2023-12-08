using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product();
            //Order();
            ProductGetDetails();

        }

        private static void Order()
        {
            OrderManager orderManager = new OrderManager(new EfOrderDal());
            foreach (var item in orderManager.GetAll())
            {
                Console.WriteLine(item.SatisTarihi);
            }
        }

        private static void Product()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            productManager.Add(new Urun { KategoriID = 3, UrunAdi = "Bardak" });
            //   productManager.Update(new Urun { KategoriID = 2, UrunAdi = "Futbol topu", UrunID = 1 });
            foreach (var urun in productManager.GetByCategoryId(3))
            {
                Console.WriteLine(urun.UrunAdi + "  " + urun.KategoriID);
            }
        }
        private static void ProductGetDetails()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            productManager.Add(new Urun { KategoriID = 3, UrunAdi = "Bardak" });
            //   productManager.Update(new Urun { KategoriID = 2, UrunAdi = "Futbol topu", UrunID = 1 });
            foreach (var urun in productManager.GetProductDetails())
            {
                Console.WriteLine(urun.UrunAdi + "  " + urun.KategoriAdi);
            }
        }
    }
}
