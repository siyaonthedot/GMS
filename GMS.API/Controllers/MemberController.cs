using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GMS.Services.Data.Models;

namespace GMS.API.Controllers
{
    //[Authorize]
    public class MemberController : ApiController
    {
        // GET: Member

       [HttpGet]
        public string  CreateMember()
        {

            return "";
        }

        [HttpGet]
        public string Get(int id)
        {

            Member member = new Member();
            var me = member.GetMember(id);

            return me.ToString();
        }
    }
}