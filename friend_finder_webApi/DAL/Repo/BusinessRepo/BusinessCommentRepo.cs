using DAL.Database;
using DAL.Interface.BusinessInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.BusinessRepo
{
    class BusinessCommentRepo : IBusinessUserCommentRepository<Comment, int>
    {
        friend_finderEntities _db;

        public BusinessCommentRepo(friend_finderEntities _db)
        {
            this._db = _db;
        }
        public void Add(Comment e)
        {
            _db.Comments.Add(e);
            _db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var data = (from pro in _db.Comments where pro.Id == id select pro).FirstOrDefault();
            _db.Comments.Remove(data);
            if (_db.SaveChanges() != 0)
            {
                return true;
            }

            return false;
        }

        public List<Comment> Get()
        {
            return _db.Comments.ToList();
        }

        public Comment Get(int id)
        {
            var comment = (from n in _db.Comments where n.Id == id select n).FirstOrDefault();
            return comment;
        }
    }
}
