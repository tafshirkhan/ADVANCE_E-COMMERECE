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
    public class BusinessUser_PostController : ApiController
    {
        [Route("api/BusinessUser_Post/CreatePost")]
        [HttpPost]
        public void Add(BusinessUserPostModel pro)
        {
            BusinessUserPostService.AddPost(pro);
        }

        [Route("api/BusinessUser_Post/DeletePost/{id}")]
        [HttpDelete]
        public HttpResponseMessage DeletePost(int id)
        {
            var result = BusinessUserPostService.Delete(id);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Post has been Deleted");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Something is wrong");
            }
        }

        [Route("api/BusinessUser_Post/GetDetails/{id}")]
        [HttpGet]

        public BusinessUserPostModel GetDetails(int id)
        {
            return BusinessUserPostService.GeDetails(id);
        }

        [Route("api/BusinessUser_Post/GetAllPost")]
        [HttpGet]
        public List<BusinessUserPostModel> GetAll()
        {
            return BusinessUserPostService.GetAllPost();
        }


        //Commenting
        [Route("api/BusinessUser_Post/AddComment")]
        [HttpPost]
        public void AddNewComment(BusinessCommentModel pro)
        {
            BusinessUserCommentService.AddComment(pro);
        }

        [Route("api/BusinessUser_Post/DeleteComment/{id}")]
        [HttpDelete]
        public HttpResponseMessage DeleteComment(int id)
        {
            var result = BusinessUserCommentService.Delete(id);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Comment has been Deleted");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Something is wrong");
            }
        }

        [Route("api/BusinessUser_Post/GetAllComment")]
        [HttpGet]

        public List<BusinessCommentModel> GetAllComment()
        {
            return BusinessUserCommentService.GetAllComment();
        }

        [Route("api/BusinessUser_Post/GetComment/{id}")]
        [HttpGet]

        public BusinessCommentModel GetComment(int id)
        {
            return BusinessUserCommentService.GeDetails(id);
        }



        //Reply to the comment
        [Route("api/BusinessUser_Post/AddReply")]
        [HttpPost]
        public void AddNewReply(BusinessReplyModel pro)
        {
            BusinessReplyService.AddReply(pro);
        }


        [Route("api/BusinessUser_Post/GetAllTeplies")]
        [HttpGet]

        public List<BusinessReplyModel> GetAllReplies()
        {
            return BusinessReplyService.GetAllReply();
        }

        [Route("api/BusinessUser_Post/GetReply/{id}")]
        [HttpGet]

        public BusinessReplyModel GetReply(int id)
        {
            return BusinessReplyService.GeDetails(id);
        }
    }
}
