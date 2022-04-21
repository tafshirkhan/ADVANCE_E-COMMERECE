using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity
{
    public class ReplyModel
    {
        public int Id { get; set; }
        public string Reply_Cmnt { get; set; }
        public int Comment_id { get; set; }
        public int User_id { get; set; }
        public System.DateTime Date { get; set; }
    }
}
