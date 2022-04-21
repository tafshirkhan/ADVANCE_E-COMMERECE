using AutoMapper;
using BEL.Entity.BusinessEntity;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.BusinessService
{
    public class CategoryService
    {
        public static void AddCategory(CategoryModel cat)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CategoryModel, Category>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Category>(cat);
            DataAccessFactory.CategoryDataAccess().Add(data);
        }

        public static List<CategoryModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Category, CategoryModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.CategoryDataAccess();
            //var data = mapper.Map<List<CategoryModel>>(da);
            var data = mapper.Map<List<Category>, List<CategoryModel>>(da.Get());
            return data;
        }

        public static CategoryModel EditCategory(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Category, CategoryModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<CategoryModel>(DataAccessFactory.CategoryDataAccess().Get(id));
            return data;
        }

        public static bool UpdateCategory(CategoryModel cat)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CategoryModel, Category>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<Category>(cat);
            var value = DataAccessFactory.CategoryDataAccess().Update(data);
            return value;
        }


        public static bool Delete(int id)
        {
            var data = DataAccessFactory.CategoryDataAccess().Delete(id);
            return data;
        }
    }
}
