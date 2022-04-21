using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity.BusinessEntity
{
    public class OrderModel
    {

        public int Id { get; set; }
        public int CartId { get; set; }
        public string Price { get; set; }
        public virtual ShoppingCartModel ShoopingCart { get; set; }
    }
}
