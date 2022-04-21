using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity.BusinessEntity
{
    public class BusinessCommentModel
    {
        public int Id { get; set; }
        public string Cmnt { get; set; }
        public int Post_id { get; set; }
        public int User_id { get; set; }
        public System.DateTime Date { get; set; }

        public virtual BusinessUserPostModel Post { get; set; }
        public virtual BusinessUserModel User { get; set; }
    }
}
