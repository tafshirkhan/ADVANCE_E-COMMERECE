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
    public class ReactSevrice
    {
        public static bool Create(ReactModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ReactModel, React>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<React>(n);
            var result = DataAccessFactory.ReactDataAccess().Add(data);
            return result;
        }

    }
}
