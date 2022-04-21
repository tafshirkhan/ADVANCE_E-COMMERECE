using DAL.Database;
using DAL.Interface.BusinessInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.BusinessRepo
{
    public class OrderRepo : IOrderRepository<OrderDetail, int>
    {
        friend_finderEntities _db;

        public OrderRepo(friend_finderEntities _db)
        {
            this._db = _db;
        }

        public void Add(OrderDetail e)
        {
            //var data = (from c in _db.OrderHeads where c.User_id == e.OrderHead.us)
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> Get()
        {
            throw new NotImplementedException();
        }

        public OrderDetail Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
