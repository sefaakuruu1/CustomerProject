using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOrderService
    {
       List<Satis> GetAll();
        void Add(Satis satis);

        void Update(Satis satis);
        void Delete(Satis satis);

        Satis GetByOrderId(int satisID);

    }
}
