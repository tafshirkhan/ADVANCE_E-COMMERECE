using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BEL.Entity
{
    public class EmployeeModel
    {
        public int Id { get; set; }

/*        [Required(ErrorMessage = "Name Required")]
        [StringLength(50)]
        [MinLength(2, ErrorMessage = "Name must be greater than 2")]
        [RegularExpression(@"^[0-9a-zA-Z''-'\s]{1,40}$", ErrorMessage = "special characters are       not  allowed.")]*/
        public string Name { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public int User_id { get; set; }
        public System.DateTime joiningDate { get; set; }

         //public HttpPostedFileBase ImageFile { get; set; }
    }
}
