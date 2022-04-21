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
    public class BusinessReplyService
    {
        public static void AddReply(BusinessReplyModel pro)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BusinessReplyModel, Reply>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Reply>(pro);
            DataAccessFactory.BusinessUserReplyDataAccess().Add(data);
        }

        public static BusinessReplyModel GeDetails(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Reply, BusinessReplyModel>();
                c.CreateMap<Post, BusinessUserPostModel>();
                c.CreateMap<User, BusinessUserModel>();
                c.CreateMap<Comment, BusinessCommentModel>();

            }
            );
            var mapper = new Mapper(config);

            var data = mapper.Map<BusinessReplyModel>(DataAccessFactory.BusinessUserReplyDataAccess().Get(id));

            return data;
        }


        public static List<BusinessReplyModel> GetAllReply()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Reply, BusinessReplyModel>();
                c.CreateMap<Post, BusinessUserPostModel>();
                c.CreateMap<User, BusinessUserModel>();
                c.CreateMap<Comment, BusinessCommentModel>();


            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.BusinessUserReplyDataAccess();
            //var data = mapper.Map<List<CategoryModel>>(da);
            //var data = mapper.Map<List<Product>, List<ProductModel>>(da.Get());
            var data = mapper.Map<List<BusinessReplyModel>>(da.Get());
            return data;
        }
    }
}
