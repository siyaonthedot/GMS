using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMS.Data.DBContext.Interface;
using GMS.Services.Data.Interface;

namespace GMS.Services.Data.Models
  
{
    public class Member
    {


        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public string Address { get; set; }
        public int BranchID { get; set; }
        public int MembershipTypeID { get; set; }
        public int ClubTypeID { get; set; }
        public string BankName { get; set; }
        public string BanchAcc { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string CellNo { get; set; }
        public string TellNo { get; set; }
        public int OccupationID { get; set; }
        public string CompanyName { get; set; }
        public string Gender { get; set; }
        public Nullable<int> Age { get; set; }
        public int StatusID { get; set; }
        public int MemberAttendencyID { get; set; }
        IMemberRepository IMemberRepository;
        public Member() { }

        public void AddMember(object obj)
        {
            // ''Member member = new Member();
            GMS.Data.DBContext.Member newMember = new GMS.Data.DBContext.Member();
           // IMemberRepository.i


        }

        public Member GetMember(int ID) 
        {
           Member member = new Member();
            var mem= IMemberRepository.GetSingle(ID);
            member.ID = mem.ID;
            return member;
        }


    }
    }

