using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BEL.Entity;
using DAL;
using DAL.Database;

namespace BLL.Service
{
    public class EmployeeService
    {
        public static bool Edit(EmployeeModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<EmployeeModel, Employee>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<Employee>(n);
            var result = DataAccessFactory.EmployeeDataAccess().Edit(data);
            return result;
        }

        public static List<EmployeeModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<EmployeeModel>>(DataAccessFactory.EmployeeDataAccess().Get());
            return data;
        }

        public static EmployeeModel Details(int id)
        {

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<EmployeeModel>(DataAccessFactory.EmployeeDataAccess().Get(id));

            return data;
        }

        public static EmployeeModel Active(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<EmployeeModel>(DataAccessFactory.EmployeeDataAccess().Active(id));
            return data;
        }

        public static EmployeeModel Deactive(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<EmployeeModel>(DataAccessFactory.EmployeeDataAccess().Deactive(id));
            return data;
        }

        public static List<EmployeeModel> Serach(string name)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<EmployeeModel>>(DataAccessFactory.SearchDataAccess().Search(name));
            return data;
        }

        public static bool Confirm(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<EmployeeModel>(DataAccessFactory.EmployeeDataAccess().Confirm(id));
            if (data != null) return true;
            return false;
            
        }


        public static List<EmployeeModel> EmpReport(DateTime? FDate, DateTime? TDate)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Employee, EmployeeModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<EmployeeModel>>(DataAccessFactory.EmpReportDataAccess().Report(FDate, TDate));
            return data;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.EmployeeDataAccess().delete(id);
            return data;
        }
    }
}
