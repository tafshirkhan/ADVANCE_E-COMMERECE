using DAL.Database;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class ReactRepo: IReactRepository<React>
    {
        friend_finderEntities db;

        public ReactRepo(friend_finderEntities db)
        {
            this.db = db;
        }

        public bool Add(React e)
        {
            if(e.User_React == "Like")
            {
                var r = new React();
                r.Post_id = e.Post_id;
                r.User_id = e.User_id;
                r.User_React = "Like";
                db.Reacts.Add(r);
            }
            else
            {
                var r = new React();
                r.Post_id = e.Post_id;
                r.User_id = e.User_id;
                r.User_React = "Dislike";
                db.Reacts.Add(r);
            }


            if (db.SaveChanges() != 0)
            {
                return true;
            }
            return false;
        }
    }
}
