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
    public class ReplyService
    {
        public static bool Create(ReplyModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ReplyModel, Reply>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<Reply>(n);
            var result = DataAccessFactory.ReplyDataAccess().Add(data);
            return result;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.ReplyDataAccess().delete(id);
            return data;
        }
    }
}
