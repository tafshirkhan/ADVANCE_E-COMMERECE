using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity.BusinessEntity
{
    public class OrderHeadModel
    {
        public int Id { get; set; }
        public int shopCartId { get; set; }
        public int User_id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public virtual ShoppingCartModel ShoppingCart { get; set; }
        public virtual BusinessUserModel User { get; set; }
    }
}
