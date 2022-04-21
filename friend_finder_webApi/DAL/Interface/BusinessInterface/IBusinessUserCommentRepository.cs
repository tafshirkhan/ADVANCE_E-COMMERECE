using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface.BusinessInterface
{
    public interface IBusinessUserCommentRepository<T, ID>
    {
        void Add(T e);
        bool Delete(ID id);
        List<T> Get();
        T Get(ID id);
    }
}
