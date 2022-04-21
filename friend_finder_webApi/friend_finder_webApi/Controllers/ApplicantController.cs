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
    public class ApplicantController : ApiController
    {
        [Route("api/Job/Applicants/All/{id}")]
        [HttpGet]
        public HttpResponseMessage GetAll(int id)
        {
            var app = ApplicantService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, app);
        }

        [Route("api/Applicants/Details/{id}")]
        [HttpGet]
        public HttpResponseMessage Details(int id)
        {
            var app = ApplicantService.Details(id);
            if (app == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Failed");
            }
            return Request.CreateResponse(HttpStatusCode.OK, app);
        }


        [Route("api/Applicants/Delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var result = ApplicantService.Delete(id);
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
