using DAL.Database;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class CommentRepo : ICmntReplyRepository<Comment, int>
    {
        friend_finderEntities db;

        public CommentRepo(friend_finderEntities db)
        {
            this.db = db;
        }

        public bool Add(Comment e)
        {
            var c = new Comment();
            c.Cmnt = e.Cmnt;
            c.Post_id = e.Post_id;
            c.User_id = e.User_id;
            c.Date = DateTime.Now;
            db.Comments.Add(c);

            if (db.SaveChanges() != 0)
            {
                return true;
            }
            return false;
        }
        
        public bool delete(int id)
        {
            var data = (from u in db.Comments where u.Id == id select u).FirstOrDefault();
            db.Comments.Remove(data);
            if (db.SaveChanges() != 0)
            {
                return true;
            }

            return false;
        }
    }
}
