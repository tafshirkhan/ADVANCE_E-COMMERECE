using DAL.Database;
using DAL.Interface;
using DAL.Interface.BusinessInterface;
using DAL.Repo;
using DAL.Repo.BusinessRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static friend_finderEntities db;
        static DataAccessFactory()
        {
            db = new friend_finderEntities();
        }

        /*Employee*/
        public static IEmpRepository<Employee, int> EmployeeDataAccess()
        {
            return new EmployeeRepo(db);
        }

        public static ISearchRepository<Employee, string> SearchDataAccess()
        {
            return new EmployeeRepo(db);
        }

        public static IReportRepositiry<Employee, DateTime?, DateTime?> EmpReportDataAccess()
        {
            return new EmployeeRepo(db);
        }

        /*Job*/
        public static IJobRepository<Job, int> JobDataAccess()
        {
            return new JobRepo(db);
        }

        /*Applicant*/
        public static IApplicantRepository<Applicant, int> ApplicantDataAccess()
        {
            return new ApplicantRepo(db);
        }

        /*Post*/
        public static IPostRepository<Post, int> PostDataAccess()
        {
            return new PostRepo(db);
        }

        /*Comment*/
        public static ICmntReplyRepository<Comment, int> CommentDataAccess()
        {
            return new CommentRepo(db);
        }
        /*Reply*/
        public static ICmntReplyRepository<Reply, int> ReplyDataAccess()
        {
            return new ReplyRepo(db);
        }

        /*Admin*/
        public static IAdminRepository<Admin, int, string> AdminDataAccess()
        {
            return new AdminRepo(db);
        }

        /*React*/
        public static IReactRepository<React> ReactDataAccess()
        {
            return new ReactRepo(db);
        }

        /*Business User Category*/
        public static ICategoryRepository<Category, int> CategoryDataAccess()
        {
            return new CategoryRepo(db);
        }

        /*Business User Product*/
        public static ICategoryRepository<Product, int> ProductDataAccess()
        {
            return new ProductRepo(db);
        }

        /*Business User ShoppingCart*/
        public static IShoppingCartRepository<ShoppingCart, int> ShoppingCartDataAccess()
        {
            return new ShoppingCartRepo(db);
        }

        /*Business User OrderHead*/
        public static IOrderHeadRepository<OrderHead, int> OrdeHeadDataAccess()
        {
            return new OrderHeadRepo(db);
        }


        /*Business User*/
        public static IBusinessUserRepository<User, int> BusinessUserDataAccess()
        {
            return new BusinessUserRepo(db);
        }


        /*Business User Post*/
        public static IBusinessPostRepository<Post, int> BusinessUserPostDataAccess()
        {
            return new BusinessUserPostRepo(db);
        }

        /*Business User Post Comment*/
        public static IBusinessUserCommentRepository<Comment, int> BusinessUserCommentDataAccess()
        {
            return new BusinessCommentRepo(db);
        }

        /*Business User Post Reply*/
        public static IBusinessUserCommentRepository<Reply, int> BusinessUserReplyDataAccess()
        {
            return new BusinessReplyRepo(db);
        }


    }
}
