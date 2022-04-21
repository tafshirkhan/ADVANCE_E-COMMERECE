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
    public class AdminController : ApiController
    {
        [Route("api/Admin/Dashboard")]
        [HttpGet]
        public int[] Dashboard()
        {
            return AdminService.Dashboard();
        }

        [Route("api/Admin/Edit/Profil")]
        [HttpPut]
        public HttpResponseMessage Edit(AdminModel e)
        {
            if (ModelState.IsValid)
            {
                var result = AdminService.EditProfile(e);
                if (result)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Edit successfully");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Not Edited");
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
        }


        [Route("api/Admin/Password")]
        [HttpPost]
        public HttpResponseMessage ChangePass(string Currentpassword, string Newpassword, string Conpassword, int id)
        {
            if (ModelState.IsValid)
            {
                var pass = AdminService.GetPass(id);

                if (Currentpassword != pass)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Current Password Doesn't match!");
                }
                else if (Newpassword != Conpassword)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "New password and Confirm password Doesn't match!");
                }
                else
                {
                    var result = AdminService.ChangePass(Newpassword, id);
                    if (result)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, "Password change successfully");
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, "Password Not change");
                    }

                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
        }

 

    }
}
