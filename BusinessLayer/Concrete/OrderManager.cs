using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class OrderManager:IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void Add(Satis satis)
        {
            _orderDal.Add(satis);
        }

        public void Delete(Satis satis)
        {
            _orderDal.Delete(satis);
        }

        public List<Satis> GetAll()
        {
           return _orderDal.GetAll();
        }

        public Satis GetByOrderId(int satisID)
        {
            return _orderDal.Get(o => o.SatisID == satisID);
        }

        public void Update(Satis satis)
        {
            _orderDal.Update(satis);
        }
    }
}
