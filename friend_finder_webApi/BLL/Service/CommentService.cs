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
    public class CommentService
    {
        public static bool Create(CommentModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CommentModel, Comment>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<Comment>(n);
            var result = DataAccessFactory.CommentDataAccess().Add(data);
            return result;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.CommentDataAccess().delete(id);
            return data;
        }
    }
}
