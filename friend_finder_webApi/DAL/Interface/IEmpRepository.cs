using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IEmpRepository<T, ID>
    {
        
        bool Edit(T e);
        bool delete(ID id);
        List<T> Get();
        T Get(ID id);
        T Active(ID id);
        T Deactive(ID id);
        T Confirm(ID id);

    }
}
