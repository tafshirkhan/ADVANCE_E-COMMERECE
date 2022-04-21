using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity
{
    public class PostModel
    {
        public int Id { get; set; }
        public string User_Post { get; set; }
        public string Image { get; set; }
        public System.DateTime Date { get; set; }
        public int User_id { get; set; }
    }
}
