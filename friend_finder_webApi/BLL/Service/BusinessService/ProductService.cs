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
    public class ProductService
    {
        public static void AddProduct(ProductModel pro)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductModel, Product>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Product>(pro);
            DataAccessFactory.ProductDataAccess().Add(data);
        }

        public static List<ProductModel> GetAllProduct()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductModel>();
                c.CreateMap<Category, CategoryModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ProductDataAccess();
            //var data = mapper.Map<List<CategoryModel>>(da);
            //var data = mapper.Map<List<Product>, List<ProductModel>>(da.Get());
            var data = mapper.Map<List<ProductModel>>(da.Get());
            return data;
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.ProductDataAccess().Delete(id);
            return data;
        }

        public static ProductModel EditProduct(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductModel>();
                c.CreateMap<Category, CategoryModel>();

            }
            );
            var mapper = new Mapper(config);
            
            var data = mapper.Map<ProductModel>(DataAccessFactory.ProductDataAccess().Get(id));
            
            return data;
        }

        public static bool UpdateProduct(ProductModel pro)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductModel, Product>();
                c.CreateMap<CategoryModel, Product>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<Product>(pro);
            var value = DataAccessFactory.ProductDataAccess().Update(data);
            return value;
        }
    }
}
