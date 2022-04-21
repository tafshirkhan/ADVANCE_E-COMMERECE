using DAL.Database;
using DAL.Interface.BusinessInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.BusinessRepo
{
    class BusinessUserPostRepo : IBusinessPostRepository<Post, int>
    {
        friend_finderEntities _db;

        public BusinessUserPostRepo(friend_finderEntities _db)
        {
            this._db = _db;
        }

        public void Add(Post e)
        {
            _db.Posts.Add(e);
            _db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var data = (from pro in _db.Posts where pro.Id == id select pro).FirstOrDefault();
            _db.Posts.Remove(data);
            if (_db.SaveChanges() != 0)
            {
                return true;
            }

            return false;
        }

        public List<Post> Get()
        {
            return _db.Posts.ToList();
        }

        public Post Get(int id)
        {
            var post = (from n in _db.Posts where n.Id == id select n).FirstOrDefault();
            return post;
        }

        public bool Update(Post e)
        {
            throw new NotImplementedException();
        }
    }
}
