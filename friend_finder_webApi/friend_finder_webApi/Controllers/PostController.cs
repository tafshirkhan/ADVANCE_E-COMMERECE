using BEL.Entity;
using BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace friend_finder_webApi.Controllers
{
    public class PostController : ApiController
    {
        [Route("api/Post/All")]
        [HttpGet]
        public List<PostCommentReplyReactUserModel> GetAll()
        {
            return PostService.Get();
        }

        [Route("api/Post/")]
        [HttpPost]
        public HttpResponseMessage Add(PostModel p)
        {
            var result = PostService.Create(p);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Added successfully");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Not Added");
            }

        }

        [Route("api/Post/Delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var result = PostService.Delete(id);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Not Deleted");
            }
        }


        /*Comment*/
        [Route("api/Comment/Create")]
        [HttpPost]
        public HttpResponseMessage AddCmnt(CommentModel p)
        {
            var result = CommentService.Create(p);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Added successfully");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Not Added");
            }

        }

        [Route("api/Comment/Delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage DeleteCmnt(int id)
        {
            var result = CommentService.Delete(id);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Not Deleted");
            }
        }


        /*Reply*/
        [Route("api/Reply/Create")]
        [HttpPost]
        public HttpResponseMessage AddRly(ReplyModel p)
        {
            var result = ReplyService.Create(p);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Added successfully");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Not Added");
            }

        }

        [Route("api/Reply/Delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage DeleteRly(int id)
        {
            var result = ReplyService.Delete(id);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Not Deleted");
            }
        }


        /*React*/
        [Route("api/React/Create")]
        [HttpPost]
        public HttpResponseMessage AddReact(ReactModel p)
        {
            var result = ReactSevrice.Create(p);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Added successfully");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Not Added");
            }

        }
    }



}
