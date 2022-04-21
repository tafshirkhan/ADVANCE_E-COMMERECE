using AutoMapper;
using BEL.Entity.BusinessEntity;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.BusinessService
{
    public class BusinessUserService
    {
        public static void AddUser(BusinessUserModel cat)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BusinessUserModel, User>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(cat);
            DataAccessFactory.BusinessUserDataAccess().Add(data);
        }


        public static BusinessUserModel GetUser(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, BusinessUserModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<BusinessUserModel>(DataAccessFactory.BusinessUserDataAccess().Get(id));
            return data;
        }
    }
}
