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
    public class JobController : ApiController
    {
        [Route("api/Job/All")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var job = JobService.Get();
            if (job.Count() == 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "No job available right now");
            }
            return Request.CreateResponse(HttpStatusCode.OK, job);
        }

        [Route("api/Job/Details/{id}")]
        [HttpGet]
        public HttpResponseMessage Details(int id)
        {
            var job = JobService.Details(id);
            if (job == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Failed");
            }
            return Request.CreateResponse(HttpStatusCode.OK, job);

        }

        [Route("api/Job/Delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var result = JobService.Delete(id);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Not Deleted");
            }
        }
    }
}
