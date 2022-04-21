using DAL.Database;
using DAL.Interface.BusinessInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.BusinessRepo
{
    class CategoryRepo : ICategoryRepository<Category, int>
    {
        friend_finderEntities _db;

        public CategoryRepo(friend_finderEntities _db)
        {
            this._db = _db;
        }

        public void Add(Category e)
        {
            _db.Categories.Add(e);
            _db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var data = (from cat in _db.Categories where cat.Id == id select cat).FirstOrDefault();
            _db.Categories.Remove(data);
            if (_db.SaveChanges() != 0)
            {
                return true;
            }

            return false;
        }

        
        public List<Category> Get()
        {
            return _db.Categories.ToList();
        }

        public Category Get(int id)
        {
            var category = (from n in _db.Categories where n.Id == id select n).FirstOrDefault();
            return category;
        }

        public bool Update(Category e)
        {
            //var category = (from cat in _db.Categories where cat.Id == e.Id select cat).FirstOrDefault();

            //category.categoryname = e.categoryname;
            //if (_db.SaveChanges() != 0) return true;
            //return false;

            var category = _db.Categories.FirstOrDefault(en => en.Id == e.Id);
            //_db.Entry(d).CurrentValues.SetValues(e);
            _db.Entry(category).State = EntityState.Modified;
           // _db.SaveChanges();

            if (_db.SaveChanges() != 0) return true;
            return false;
        }
    }
}
