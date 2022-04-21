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
    public class PostService
    {
        public static List<PostCommentReplyReactUserModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Post, PostCommentReplyReactUserModel>();
                c.CreateMap<Comment, CommentReplyModel>();
                c.CreateMap<React, ReactModel>(); 
                c.CreateMap<Reply, ReplyModel>();
                c.CreateMap<User, UserEmployeeModel>();
                c.CreateMap<Employee, EmployeeModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<PostCommentReplyReactUserModel>>(DataAccessFactory.PostDataAccess().Get());
            return data;
        }

        public static bool Create(PostModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PostModel, Post>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<Post>(n);
            var result = DataAccessFactory.PostDataAccess().Add(data);
            return result;
        } 

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.PostDataAccess().delete(id);
            return data;
        }
    }
}
