﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GMS.Data.DBContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class crudEntities : DbContext
    {
        public crudEntities()
            : base("name=crudEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Business> Businesses { get; set; }
        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<Function> Functions { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<MemberAttendency> MemberAttendencies { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MemberShipType> MemberShipTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SecondaryMember> SecondaryMembers { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<UserFunction> UserFunctions { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}