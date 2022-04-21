using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity
{
    public class CommentModel
    {
        public int Id { get; set; }
        public string Cmnt { get; set; }
        public int Post_id { get; set; }
        public int User_id { get; set; }
        public System.DateTime Date { get; set; }
    }
}
