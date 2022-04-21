using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity
{
    public class UserEmployeeModel: UserModel
    {
        public UserEmployeeModel()
        {
            Employees = new List<EmployeeModel>();
        }
        public virtual List<EmployeeModel> Employees { get; set; }
    
    }
}
