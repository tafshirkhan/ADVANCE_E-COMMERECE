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
    public class ShoppingCartService
    {
        public static void AddShopping(ShoppingCartModel pro)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ShoppingCartModel, ShoppingCart>();
                //c.CreateMap<ProductModel, Product>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<ShoppingCart>(pro);
            DataAccessFactory.ShoppingCartDataAccess().Add(data);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.ShoppingCartDataAccess().Delete(id);
            return data;
        }

        public static List<ShoppingCartModel> GetAllCart()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ShoppingCart, ShoppingCartModel>();
                c.CreateMap<Product, ProductModel>();
                c.CreateMap<Category, CategoryModel>();
                c.CreateMap<User, BusinessUserModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ShoppingCartDataAccess();
            //var data = mapper.Map<List<CategoryModel>>(da);
            //var data = mapper.Map<List<Product>, List<ProductModel>>(da.Get());
            var data = mapper.Map<List<ShoppingCartModel>>(da.Get());
            return data;
        }

        public static ShoppingCartModel EditCart(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ShoppingCart, ShoppingCartModel>();
                c.CreateMap<Product, ProductModel>();
                c.CreateMap<Category, CategoryModel>();
                c.CreateMap<User, BusinessUserModel>();

            }
            );
            var mapper = new Mapper(config);

            var data = mapper.Map<ShoppingCartModel>(DataAccessFactory.ShoppingCartDataAccess().Get(id));

            return data;
        }
    }
}
