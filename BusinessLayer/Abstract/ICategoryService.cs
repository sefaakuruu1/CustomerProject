using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface ICategoryService
    {
        List<Kategori> GetAll();

        void Add(Kategori kategori);

        void Delete(Kategori kategori);

        void Update(Kategori kategori);
    }
}
