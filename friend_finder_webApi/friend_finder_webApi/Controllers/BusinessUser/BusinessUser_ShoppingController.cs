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
    public class BusinessUser_ShoppingController : ApiController
    {
        [Route("api/BusinessUser_Shopping/CreateCart")]
        [HttpPost]
        public void Add(ShoppingCartModel pro)
        {
            ShoppingCartService.AddShopping(pro);
        }


        [Route("api/BusinessUser_Shopping/DeleteCart/{id}")]
        [HttpDelete]
        public HttpResponseMessage DeleteCart(int id)
        {
            var result = ShoppingCartService.Delete(id);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Cart has been Deleted");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Something is wrong");
            }
        }

        [Route("api/BusinessUser_Shopping/GetAllCart")]
        [HttpGet]
        public List<ShoppingCartModel> GetAll()
        {
            return ShoppingCartService.GetAllCart();
        }

        [Route("api/BusinessUser_Shopping/EditProduct/{id}")]
        [HttpGet]

        public ShoppingCartModel Edit(int id)
        {
            return ShoppingCartService.EditCart(id);
        }
    }
}
