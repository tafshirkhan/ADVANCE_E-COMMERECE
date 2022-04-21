using AutoMapper;
using BEL.Entity;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class ApplicantService
    {
        public static List<ApplicantUserEmployeeModel> Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Applicant, ApplicantUserEmployeeModel>();
                c.CreateMap<User, UserEmployeeModel>();
                c.CreateMap<Employee,EmployeeModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ApplicantUserEmployeeModel>>(DataAccessFactory.ApplicantDataAccess().Get(id));
            return data;
        }

        public static ApplicantUserEmployeeModel Details(int id)
        {

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Applicant, ApplicantUserEmployeeModel>();
                c.CreateMap<User, UserEmployeeModel>();
                c.CreateMap<Employee, EmployeeModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<ApplicantUserEmployeeModel>(DataAccessFactory.ApplicantDataAccess().Details(id));

            return data;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.ApplicantDataAccess().delete(id);
            return data;
        }
    }
}
