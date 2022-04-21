using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IReportRepositiry<T, FDate, TDate>
    {
        List<T> Report(FDate FromDate, TDate ToDate);
    }
}
