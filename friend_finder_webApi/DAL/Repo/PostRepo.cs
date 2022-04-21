using DAL.Database;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class PostRepo : IPostRepository<Post, int>
    {
        friend_finderEntities db;

        public PostRepo(friend_finderEntities db)
        {
            this.db = db;
        }
        public bool Add(Post e)
        {
            var p = new Post();
            p.User_Post = e.User_Post;
            p.Image = e.Image;
            p.Date = DateTime.Now;
            p.User_id = e.User_id;
            db.Posts.Add(p);

            if (db.SaveChanges() != 0)
            {
                return true;
            }
            return false;
        }

        public bool delete(int id)
        {
            var data = (from u in db.Posts where u.Id == id select u).FirstOrDefault();
            db.Posts.Remove(data);
            if (db.SaveChanges() != 0)
            {
                return true;
            }

            return false;
        }

        public List<Post> Get()
        {
            var data = db.Posts.ToList();
            return data;
        }
    }
}
