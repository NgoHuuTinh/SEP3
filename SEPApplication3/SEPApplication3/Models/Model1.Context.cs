﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SEPApplication3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sepoopcsEntities : DbContext
    {
        public sepoopcsEntities()
            : base("name=sepoopcsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
