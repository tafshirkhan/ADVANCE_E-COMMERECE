using DAL.Database;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class AdminRepo:IAdminRepository<Admin, int, string>
    {

        friend_finderEntities db;

        public AdminRepo(friend_finderEntities db)
        {
            this.db = db;
        }

        public bool ChangePassword(string Newpassword, int id)
        {

            var a = (from u in db.Users where u.Id == id select u).FirstOrDefault();
            a.Password = Newpassword;
            if (db.SaveChanges() != 0) return true;
            return false;

        }

        public bool EditProfile(Admin e)
        {
            var a = (from u in db.Admins where u.Id == e.Id select u).FirstOrDefault();

            a.Name = e.Name;
            a.Email = e.Email;
            a.Image = e.Image;
            //db.Entry(emp).CurrentValues.SetValues(e);
            if (db.SaveChanges() != 0) return true;
            return false;
        }

        public string GetPass(int id)
        {
            var data = (from u in db.Users where u.Id == id select u.Password).FirstOrDefault();
            return data;
        }

        public int[] number()
        {
            var User_data = (from u in db.Users where u.Type == "User" select u).ToList().Count;
            var Business_data = (from u in db.Users where u.Type == "Business" select u).ToList().Count;
            var Recruiter_data = (from u in db.Users where u.Type == "Recruiter" select u).ToList().Count;
            var Job_data = db.Jobs.ToList().Count;

            /*var Post_data = db.Posts.ToList()*/
            ;


            int[] num = new int[4];
            num[0] = User_data;
            num[1] = Business_data;
            num[2] = Recruiter_data;
            num[3] = Job_data;

            return num;
        }
    }
}
