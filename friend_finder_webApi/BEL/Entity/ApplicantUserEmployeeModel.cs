using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity
{
    public class ApplicantUserEmployeeModel: ApplicantModel
    {
        public virtual UserEmployeeModel User { get; set; }
    }
}
