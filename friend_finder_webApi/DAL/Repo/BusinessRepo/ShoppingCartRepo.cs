using DAL.Database;
using DAL.Interface.BusinessInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.BusinessRepo
{
    class ShoppingCartRepo : IShoppingCartRepository<ShoppingCart, int>
    {
        friend_finderEntities _db;

        public ShoppingCartRepo(friend_finderEntities _db)
        {
            this._db = _db;
        }

        public void Add(ShoppingCart e)
        {
            var s = new ShoppingCart();
            
            var cartPro = _db.ShoppingCarts.Where(p => p.productId == e.productId).FirstOrDefault();
            //var productPrice = cartPro.Product.productPrice;
            if(cartPro == null)
            {
                //e.price = int.Parse(productPrice);
                _db.ShoppingCarts.Add(e);
            }
            else
            {
               cartPro.count += e.count;
            }
            _db.SaveChanges();
            


        }

        public bool Delete(int id)
        {
            var data = (from shop in _db.ShoppingCarts where shop.Id == id select shop).FirstOrDefault();
            _db.ShoppingCarts.Remove(data);
            if (_db.SaveChanges() != 0)
            {
                return true;
            }

            return false;
        }

        public List<ShoppingCart> Get()
        {
            return _db.ShoppingCarts.ToList();
        }

        public ShoppingCart Get(int id)
        {
            var cart = (from n in _db.ShoppingCarts where n.Id == id select n).FirstOrDefault();
            return cart;
        }
    }
}
