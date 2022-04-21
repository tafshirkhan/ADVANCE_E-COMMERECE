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
    public class OrderHeadService
    {
        public static void AddOrderHead(OrderHeadModel pro)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderHeadModel, OrderHead>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<OrderHead>(pro);
            DataAccessFactory.OrdeHeadDataAccess().Add(data);
        }
    }
}
