using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity.BusinessEntity
{
    public class BusinessReplyModel
    {
        public int Id { get; set; }
        public string Reply_Cmnt { get; set; }
        public int Comment_id { get; set; }
        public int User_id { get; set; }
        public System.DateTime Date { get; set; }

        public virtual BusinessCommentModel Comment { get; set; }
        public virtual BusinessUserModel User { get; set; }
    }
}
