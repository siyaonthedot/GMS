﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GMS.API.Models
{
    public class MemberModels
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
        //public virtual Branch Branch { get; set; }
        //public virtual Club Club { get; set; }
        //public virtual Member Members1 { get; set; }
        //public virtual Member Member1 { get; set; }
        //public virtual MemberShipType MemberShipType { get; set; }
        //public virtual Status Status { get; set; }
    }
}