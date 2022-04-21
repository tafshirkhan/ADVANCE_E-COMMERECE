using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity.BusinessEntity
{
    public class OrderDetailModel
    {
        public int Id { get; set; }
        public int OrderHeadId { get; set; }
        public string price { get; set; }

        public virtual OrderHeadModel OrderHead { get; set; }
    }
}
