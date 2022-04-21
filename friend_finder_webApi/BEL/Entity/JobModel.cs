using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity
{
    public class JobModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public int User_id { get; set; }
    }
}
