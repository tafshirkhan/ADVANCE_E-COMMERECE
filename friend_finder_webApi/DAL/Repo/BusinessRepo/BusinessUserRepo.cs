using DAL.Database;
using DAL.Interface.BusinessInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.BusinessRepo
{
    class BusinessUserRepo : IBusinessUserRepository<User, int>
    {
        friend_finderEntities _db;
        public BusinessUserRepo(friend_finderEntities _db)
        {
            this._db = _db;
        }
        public void Add(User e)
        {
            _db.Users.Add(e);
            _db.SaveChanges();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            var user = (from n in _db.Users where n.Id == id select n).FirstOrDefault();
            return user;
        }

       
    }
}
