using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Kategori kategori)
        {
            _categoryDal.Add(kategori);
        }

        public void Delete(Kategori kategori)
        {
            _categoryDal.Delete(kategori);
        }

        public List<Kategori> GetAll()
        {
           return _categoryDal.GetAll();
        }

        public void Update(Kategori kategori)
        {
            _categoryDal.Update(kategori);
        }
    }
}
