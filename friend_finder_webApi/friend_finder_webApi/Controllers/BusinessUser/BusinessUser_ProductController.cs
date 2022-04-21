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
    public class BusinessUser_ProductController : ApiController
    {
        [Route("api/BusinessUser_Product/CreateProduct")]
        [HttpPost]
        public void Add(ProductModel pro)
        {
            ProductService.AddProduct(pro);
        }

        [Route("api/BusinessUser_Product/GetAllProduct")]
        [HttpGet]
        public List<ProductModel> GetAll()
        {
            return ProductService.GetAllProduct();
        }

        [Route("api/BusinessUser_Product/DeleteProduct/{id}")]
        [HttpDelete]
        public HttpResponseMessage DeleteProduct(int id)
        {
            var result = ProductService.Delete(id);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Product has been Deleted");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Something is wrong");
            }
        }

        [Route("api/BusinessUser_Product/EditProduct/{id}")]
        [HttpGet]

        public ProductModel Edit(int id)
        {
            return ProductService.EditProduct(id);
        }

        [Route("api/BusinessUser_Product/UpdateProduct")]
        [HttpPut]
        public HttpResponseMessage Edit(ProductModel pro)
        {
            if (ModelState.IsValid)
            {
                var value = ProductService.UpdateProduct(pro);
                if (value)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Product updated successfully");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Not Updated");
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
        }
    }
}
