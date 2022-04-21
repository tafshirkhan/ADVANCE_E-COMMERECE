using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity
{
    public class ReactModel
    {
        public int Id { get; set; }
        public string User_React { get; set; }
        public int User_id { get; set; }
        public int Post_id { get; set; }
    }
}
