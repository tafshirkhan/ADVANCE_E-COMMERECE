using DAL.Database;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAL.Repo
{
    public class EmployeeRepo : IEmpRepository<Employee, int>,ISearchRepository<Employee, string>,IReportRepositiry<Employee, DateTime?, DateTime?>
    {
        friend_finderEntities db;

        public EmployeeRepo(friend_finderEntities db)
        {
            this.db = db;
        }

        public bool delete(int id)
        {
            var emp_data = (from u in db.Employees where u.Id == id select u).FirstOrDefault();
            var user_data = (from u in db.Users where u.Id == emp_data.User_id select u).FirstOrDefault();

            //Applicants
            var Applicants_data = (from ap in db.Applicants where ap.User_id == emp_data.User_id select ap).ToList();
            foreach (var apli in Applicants_data)
            {
                db.Applicants.Remove(apli);
            }


            //Job
            var Job_data = (from j in db.Jobs where j.User_id == emp_data.User_id select j).ToList();
            foreach (var job in Job_data)
            {
                //Applicants under single Job
                var App_data = (from ap in db.Applicants where ap.Job_id == job.Id select ap).ToList();
                foreach (var a in App_data)
                {
                    db.Applicants.Remove(a);
                }
                db.Jobs.Remove(job);
            }

            //React
            var react_data = (from rat in db.Reacts where rat.User_id == emp_data.User_id select rat).ToList();
            foreach (var react in react_data)
            {
                db.Reacts.Remove(react);
            }

            //Reply
            var reply_data = (from rep in db.Replies where rep.User_id == emp_data.User_id select rep).ToList();
            foreach (var reply in reply_data)
            {
                db.Replies.Remove(reply);
            }

            //comment
            var comment_data = (from c in db.Comments where c.User_id == emp_data.User_id select c).ToList();
            foreach (var comment in comment_data)
            {
                var r_data = (from r in db.Replies where r.Comment_id == comment.Id select r).ToList();
                foreach (var r in r_data)
                {
                    db.Replies.Remove(r);
                }
                db.Comments.Remove(comment);
            }

            //Post
            var Post_data = (from p in db.Posts where p.User_id == emp_data.User_id select p).ToList();

            foreach (var post in Post_data)
            {
                var comnt_data = (from c in db.Comments where c.Post_id == post.Id select c).ToList();
                foreach (var cent in comnt_data)
                {
                    var r_data = (from r in db.Replies where r.Comment_id == cent.Id select r).ToList();
                    foreach (var r in r_data)
                    {
                        db.Replies.Remove(r);
                    }
                    db.Comments.Remove(cent);
                }
                var ract_data = (from rat in db.Reacts where rat.Post_id == post.Id select rat).ToList();
                foreach (var r in ract_data)
                {
                    db.Reacts.Remove(r);
                }
                db.Posts.Remove(post);
            }


            db.Employees.Remove(emp_data);


            if (user_data != null)
            {
                db.Users.Remove(user_data);
                db.SaveChanges();
                return true;
            }

            return false;

        }

        public bool Edit(Employee e)
        {
            var emp = (from u in db.Employees where u.Id == e.Id select u).FirstOrDefault();

            /*if (e.ImageFile != null)
            {
                string fileName = Path.GetFileNameWithoutExtension(e.ImageFile.FileName);
                string extension = Path.GetExtension(e.ImageFile.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                e.Image = "~/Images/Employee/" + fileName;
                fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/Images/Employee/"), fileName);
                e.ImageFile.SaveAs(fileName);
                emp.Image = e.Image;
            }*/
            emp.Name = e.Name;
            emp.Email = e.Email;
            emp.Name = e.Name;
            emp.joiningDate = e.joiningDate;
            emp.Status = e.Status;
            //db.Entry(emp).CurrentValues.SetValues(e);
            if (db.SaveChanges() != 0) return true;
            return false;
        }

        public List<Employee> Get()
        {
            var data = db.Employees.ToList();
            return data;
        }

        public Employee Get(int id)
        {
            var data = (from u in db.Employees where u.Id == id select u).FirstOrDefault();
            return data;
        }

        public Employee Active(int id)
        {
            var data = (from u in db.Employees where u.Id == id select u).FirstOrDefault();
            data.Status = "Active";
            db.SaveChanges();
            return data;
        }

        public Employee Deactive(int id)
        {
            var data = (from u in db.Employees where u.Id == id select u).FirstOrDefault();
            data.Status = "Deactive";
            db.SaveChanges();
            return data;
        }

        public List<Employee> Search(string name)
        {
            var data = db.Employees.ToList();
            data = (from u in db.Employees where u.Name.Contains(name) select u).ToList();
            return data;
        }

        public Employee Confirm(int id)
        {
            var data = (from u in db.Employees where u.Id == id select u).FirstOrDefault();
            data.Status = "Active";
            db.SaveChanges();
            return data;
/*            if (db.SaveChanges() != 0) return true;
            return false;*/
        }

        public List<Employee> Report(DateTime? FromDate, DateTime? ToDate)
        {
            var data = (from u in db.Employees where (u.joiningDate >= FromDate && u.joiningDate <= ToDate) select u).ToList();
            return data;
        }

    }
}
