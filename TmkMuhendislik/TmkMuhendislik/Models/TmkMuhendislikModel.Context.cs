﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using TmkMuhendislik.Models;

namespace TmkMuhendislik
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TmkMuhendislikEntities : DbContext
    {
        public TmkMuhendislikEntities()
            : base("name=TmkMuhendislikEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminInfo> AdminInfoes { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
