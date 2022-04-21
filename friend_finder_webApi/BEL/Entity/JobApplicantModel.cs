using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity
{
    public class JobApplicantModel: JobModel
    {
        public JobApplicantModel()
        {
            Applicants = new List<ApplicantModel>();
        }

        public virtual List<ApplicantModel> Applicants { get; set; }
    }
}
