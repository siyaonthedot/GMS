using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http.Routing;
using GMS.Data.DBContext.Interface;

namespace GMS.API.Models
{
   public class MemberModelFactory
    {

        private UrlHelper _urlHelper;
        private IMemberRepository _repo;

        public MemberModelFactory(HttpRequestMessage request, IMemberRepository repo)
        {
            _urlHelper = new UrlHelper(request);
            _repo = repo;
        }

    }
}
