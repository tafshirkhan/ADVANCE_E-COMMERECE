using DAL.Database;
using DAL.Interface.BusinessInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.BusinessRepo
{
    class BusinessReplyRepo : IBusinessUserCommentRepository<Reply, int>
    {
        friend_finderEntities _db;

        public BusinessReplyRepo(friend_finderEntities _db)
        {
            this._db = _db;
        }
        public void Add(Reply e)
        {
            _db.Replies.Add(e);
            _db.SaveChanges();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reply> Get()
        {
            return _db.Replies.ToList();
        }

        public Reply Get(int id)
        {
            var reply = (from n in _db.Replies where n.Id == id select n).FirstOrDefault();
            return reply;
        }
    }
}
