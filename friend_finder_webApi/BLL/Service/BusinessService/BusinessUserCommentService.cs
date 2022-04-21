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
    public class BusinessUserCommentService
    {
        public static void AddComment(BusinessCommentModel pro)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BusinessCommentModel, Comment>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Comment>(pro);
            DataAccessFactory.BusinessUserCommentDataAccess().Add(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.BusinessUserCommentDataAccess().Delete(id);
            return data;
        }

        public static BusinessCommentModel GeDetails(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Comment, BusinessCommentModel>();
                c.CreateMap<Post, BusinessUserPostModel>();
                c.CreateMap<User, BusinessUserModel>();


            }
            );
            var mapper = new Mapper(config);

            //var data = mapper.Map<List<BusinessCommentModel>>(DataAccessFactory.BusinessUserCommentDataAccess().Get(id));
            var data = mapper.Map<BusinessCommentModel>(DataAccessFactory.BusinessUserCommentDataAccess().Get(id));

            return data;
        }

        public static List<BusinessCommentModel> GetAllComment()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Comment, BusinessCommentModel>();
                c.CreateMap<Post, BusinessUserPostModel>();
                c.CreateMap<User, BusinessUserModel>();


            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.BusinessUserCommentDataAccess();
            //var data = mapper.Map<List<CategoryModel>>(da);
            //var data = mapper.Map<List<Product>, List<ProductModel>>(da.Get());
            var data = mapper.Map<List<BusinessCommentModel>>(da.Get());
            return data;
        }
    }
}
