using BEL.Entity.BusinessEntity;
using BLL.Service.BusinessService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace friend_finder_webApi.Controllers.BusinessUser
{
    public class BusinessUser_OrderHeadController : ApiController
    {
        [Route("api/BusinessUser_OrderHead/CreateOrderHead")]
        [HttpPost]
        public void Add(OrderHeadModel pro)
        {
            OrderHeadService.AddOrderHead(pro);
        }
    }
}
