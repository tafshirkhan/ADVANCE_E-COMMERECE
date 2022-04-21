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
    public class EmployeeController : ApiController
    {
        [Route("api/Employee/All")]
        [HttpGet]
        public List<EmployeeModel> GetAll()
        {
            return EmployeeService.Get();
        }

        [Route("api/Employee/Details/{id}")]
        [HttpGet]
        public EmployeeModel Details(int id)
        {
            return EmployeeService.Details(id);
        }

        [Route("api/Employee/Edit")]
        [HttpPut]
        public HttpResponseMessage Edit(EmployeeModel e)
        {
            if (ModelState.IsValid)
            {
                var result = EmployeeService.Edit(e);
                if(result)
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

        [Route("api/Employee/Active/{id}")]
        [HttpPut]
        public EmployeeModel Active(int id)
        {
            return EmployeeService.Active(id);
        }

        [Route("api/Employee/Deactive/{id}")]
        [HttpPut]
        public EmployeeModel Deactive(int id)
        {
            return EmployeeService.Deactive(id);
        }

        /*   [Route("api/student/")]
           [HttpGet]
           public HttpResponseMessage Get()
           {
               var st = StudentService.Get();
               return Request.CreateResponse(HttpStatusCode.OK, st);
           }
           [Route("api/demo")]
           public HttpResponseMessage GetAll()
           {


               return Request.CreateResponse(HttpStatusCode.OK, new { A1 = new int[1, 2], Ob = new { Id = 1, Name = 2 } });
           }*/

        [Route("api/Employee/Search")]
        [HttpPut]
        public HttpResponseMessage SerachEmp(String name)
        {
            var emp = EmployeeService.Serach(name);

            if (String.IsNullOrEmpty(name)) 
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Please search something!!");
            }
            if (emp.Count() == 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Nothing match");
            }

            return Request.CreateResponse(HttpStatusCode.OK, emp);
        }

        [Route("api/Employee/Confirm/{id}")]
        [HttpPut]
        public HttpResponseMessage Confirm(int id)
        {
            var emp=  EmployeeService.Confirm(id);

            if (emp)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Confirm request");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Failed");
            }
        }

        [Route("api/Employee/Report")]
        [HttpPut]
        public HttpResponseMessage EmpReport(DateTime? FromDate, DateTime? ToDate)
        {
            var emp = EmployeeService.EmpReport(FromDate, ToDate);

            if (FromDate == null || ToDate == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Please enter date!!");
            }
            if (emp.Count() == 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Nothing match");
            }

            return Request.CreateResponse(HttpStatusCode.OK, emp);
        }

        [Route("api/Employee/Delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var result = EmployeeService.Delete(id);
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
