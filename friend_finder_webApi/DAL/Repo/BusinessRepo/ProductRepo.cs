using DAL.Database;
using DAL.Interface.BusinessInterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Repo.BusinessRepo
{
    class ProductRepo : ICategoryRepository<Product, int>
    {

        friend_finderEntities _db;

        public ProductRepo(friend_finderEntities _db)
        {
            this._db = _db;
        }
        public void Add(Product e)
        {
            //string fileName = Path.GetFileNameWithoutExtension(e.ImageFiles.FileName);
            //string extension = Path.GetExtension(e.ImageFiles.FileName);
            //fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            //e.productImage = "~/ProductImage/" + fileName;
            //fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/ProductImage/"), fileName);
            //e.ImageFiles.SaveAs(fileName);

            _db.Products.Add(e);
            _db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var data = (from pro in _db.Products where pro.Id == id select pro).FirstOrDefault();
            _db.Products.Remove(data);
            if (_db.SaveChanges() != 0)
            {
                return true;
            }

            return false;
        }

        public List<Product> Get()
        {
            return _db.Products.ToList();
        }

        public Product Get(int id)
        {
            var product = (from n in _db.Products where n.Id == id select n).FirstOrDefault();
            return product;
        }

        public bool Update(Product e)
        {
            var product = _db.Products.FirstOrDefault(en => en.Id == e.Id);
            //_db.Entry(d).CurrentValues.SetValues(e);
            _db.Entry(product).State = EntityState.Modified;
            // _db.SaveChanges();

            if (_db.SaveChanges() != 0) return true;
            return false;
        }
    }
}
