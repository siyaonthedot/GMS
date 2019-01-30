using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMS.Data.DBContext.Interface;

namespace GMS.Data.DBContext.Models
{
    public class MemberRepository: BaseRepository<Member>
    {
        public MemberRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
}
