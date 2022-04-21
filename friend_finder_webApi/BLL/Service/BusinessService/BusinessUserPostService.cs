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
    public class BusinessUserPostService
    {
        public static void AddPost(BusinessUserPostModel pro)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BusinessUserPostModel, Post>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Post>(pro);
            DataAccessFactory.BusinessUserPostDataAccess().Add(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.BusinessUserPostDataAccess().Delete(id);
            return data;
        }

        public static BusinessUserPostModel GeDetails(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Post, BusinessUserPostModel>();
                c.CreateMap<User, BusinessUserModel>();
                //c.CreateMap<BusinessCommentModel, Comment>();

            }
            );
            var mapper = new Mapper(config);

            var data = mapper.Map<BusinessUserPostModel>(DataAccessFactory.BusinessUserPostDataAccess().Get(id));

            return data;
        }


        public static List<BusinessUserPostModel> GetAllPost()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, BusinessUserModel>();
                c.CreateMap<Post, BusinessUserPostModel>();
                

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.BusinessUserPostDataAccess();
            //var data = mapper.Map<List<CategoryModel>>(da);
            //var data = mapper.Map<List<Product>, List<ProductModel>>(da.Get());
            var data = mapper.Map<List<BusinessUserPostModel>>(da.Get());
            return data;
        }
    }
}
