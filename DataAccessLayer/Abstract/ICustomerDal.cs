using Core.DataAccess;
using DataAccessLayer.Abstract;
using Entities.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public interface ICustomerDal:IEntityRepository<Musteri>
    {
    }
}