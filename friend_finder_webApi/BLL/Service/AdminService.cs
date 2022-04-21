using AutoMapper;
using BEL.Entity;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class AdminService
    {
        public static int[] Dashboard()
        {
            return DataAccessFactory.AdminDataAccess().number();

        }

        public static bool EditProfile(AdminModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminModel, Admin>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<Admin>(n);
            var result = DataAccessFactory.AdminDataAccess().EditProfile(data);
            return result;
        }

        public static string GetPass(int id)
        {
            var data = DataAccessFactory.AdminDataAccess().GetPass(id);
            return data;
        }

        public static bool ChangePass(string newPassint,int id)
        {
            var data = DataAccessFactory.AdminDataAccess().ChangePassword(newPassint,id);
            return data;
        }
    }
}
