﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace schoolSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class schoolSystemDBEntities7 : DbContext
    {
        public schoolSystemDBEntities7()
            : base("name=schoolSystemDBEntities7")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ogrenciler> Ogrenciler { get; set; }
        public virtual DbSet<Ogretmenler> Ogretmenler { get; set; }
        public virtual DbSet<Siniflar> Siniflar { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
