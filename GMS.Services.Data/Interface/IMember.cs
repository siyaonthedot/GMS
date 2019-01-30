using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMS.Services.Data.Models;

namespace GMS.Services.Data.Interface
{
   public interface IMember
    {

        List<Member> GetAllEmployee();
    }
}
