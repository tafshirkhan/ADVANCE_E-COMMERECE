using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BEL.Entity.BusinessEntity
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string productName { get; set; }
        public string productPrice { get; set; }
        public string productImage { get; set; }
        public string productDescription { get; set; }
        public string productQuantity { get; set; }
        public int categoryId { get; set; }

        public virtual CategoryModel Category { get; set; }

        //public HttpPostedFileBase ImageFiles { get; set; }
    }
}
