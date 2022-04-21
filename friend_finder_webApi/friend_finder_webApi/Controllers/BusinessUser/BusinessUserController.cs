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
    public class BusinessUserController : ApiController
    {
        [Route("api/BusinessUser/CreateUser")]
        [HttpPost]
        public void Add(BusinessUserModel cat)
        {
            BusinessUserService.AddUser(cat);
        }

        [Route("api/BusinessUser/GeUser/{id}")]
        [HttpGet]

        public BusinessUserModel Getser(int id)
        {
            return BusinessUserService.GetUser(id);
        }
    }
}
