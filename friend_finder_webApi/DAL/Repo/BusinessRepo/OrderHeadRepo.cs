using DAL.Database;
using DAL.Interface.BusinessInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.BusinessRepo
{
    class OrderHeadRepo : IOrderHeadRepository<OrderHead, int>
    {
        friend_finderEntities _db;

        public OrderHeadRepo(friend_finderEntities _db)
        {
            this._db = _db;
        }
        public void Add(OrderHead e)
        {
            //var data = (from cart in _db.ShoppingCarts where cart.Id == e.Id && 
                        //cart.user_id == e.User_id select cart);
            
            _db.OrderHeads.Add(e);
            _db.SaveChanges();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderHead> Get()
        {
            throw new NotImplementedException();
        }

        public OrderHead Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
