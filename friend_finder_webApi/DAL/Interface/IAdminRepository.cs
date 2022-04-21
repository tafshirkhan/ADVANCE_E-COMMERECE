using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IAdminRepository<T,ID,NewPass>
    {

        ID[] number();
        bool ChangePassword(NewPass NewPassword, ID id);
        bool EditProfile(T e);

        string GetPass(ID id);
    }
}
