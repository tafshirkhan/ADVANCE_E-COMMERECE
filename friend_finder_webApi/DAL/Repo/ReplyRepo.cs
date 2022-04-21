using DAL.Database;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class ReplyRepo: ICmntReplyRepository<Reply, int>
    {
        friend_finderEntities db;

        public ReplyRepo(friend_finderEntities db)
        {
            this.db = db;
        }

        public bool Add(Reply e)
        {
            var r = new Reply();
            r.Reply_Cmnt = e.Reply_Cmnt;
            r.Comment_id = e.Comment_id;
            r.User_id = e.User_id;
            r.Date = DateTime.Now;
            db.Replies.Add(r);

            if (db.SaveChanges() != 0)
            {
                return true;
            }
            return false;
        }

        public bool delete(int id)
        {
            var data = (from u in db.Replies where u.Id == id select u).FirstOrDefault();
            db.Replies.Remove(data);
            if (db.SaveChanges() != 0)
            {
                return true;
            }

            return false;
        }


    }
}
