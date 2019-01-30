using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS.Data.DBContext.Interface
{
   public interface IMemberRepository
    {
        Member GetSingle(int memberId);
    }
}
