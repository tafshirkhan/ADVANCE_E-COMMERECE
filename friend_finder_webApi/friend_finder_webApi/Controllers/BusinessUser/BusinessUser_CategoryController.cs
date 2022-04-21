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
    public class BusinessUser_CategoryController : ApiController
    {
        [Route("api/BusinessUser_Category/CreateCategory")]
        [HttpPost]
        public void Add(CategoryModel cat)
        {
            CategoryService.AddCategory(cat);
        }


        [Route("api/BusinessUser_Category/GetAllCategory")]
        [HttpGet]
        public List<CategoryModel> GetAll()
        {
            return CategoryService.GetAll();
        }

        [Route("api/BusinessUser_Category/EditCategory/{id}")]
        [HttpGet]

        public CategoryModel Edit(int id)
        {
            return CategoryService.EditCategory(id);
        }

        [Route("api/BusinessUser_Category/UpdateCategory")]
        [HttpPut]
        public HttpResponseMessage Edit(CategoryModel cat)
        {
            if (ModelState.IsValid)
            {
                var value = CategoryService.UpdateCategory(cat);
                if (value)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Category updated successfully");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Not Updated");
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
        }

        [Route("api/BusinessUser_Category/DeleteCategory/{id}")]
        [HttpDelete]
        public HttpResponseMessage DeleteCategory(int id)
        {
            var result = CategoryService.Delete(id);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Category Deleted");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Not Deleted");
            }
        }
    }
}
