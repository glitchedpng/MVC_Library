﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Library.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBKUTUPHANE_Entities : DbContext
    {
        public DBKUTUPHANE_Entities()
            : base("name=DBKUTUPHANE_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BOOK> BOOK { get; set; }
        public virtual DbSet<CASE> CASE { get; set; }
        public virtual DbSet<CATEGORY> CATEGORY { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEE { get; set; }
        public virtual DbSet<MEMBER> MEMBER { get; set; }
        public virtual DbSet<MOVEMENT> MOVEMENT { get; set; }
        public virtual DbSet<PENALTY> PENALTY { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<WRITER> WRITER { get; set; }
        public virtual DbSet<MESSAGE> MESSAGE { get; set; }
        public virtual DbSet<ANNOUNCEMENT> ANNOUNCEMENT { get; set; }
        public virtual DbSet<ADMIN> ADMIN { get; set; }
    }
}
