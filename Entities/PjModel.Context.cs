﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PutraJayaWebApps.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PutraJayaAppsEntities : DbContext
    {
        public PutraJayaAppsEntities()
            : base("name=PutraJayaAppsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<MsInventory> MsInventories { get; set; }
        public DbSet<MsMenu> MsMenus { get; set; }
        public DbSet<MsOrder> MsOrders { get; set; }
        public DbSet<MsPayment> MsPayments { get; set; }
        public DbSet<MsRole> MsRoles { get; set; }
        public DbSet<MsTransaction> MsTransactions { get; set; }
        public DbSet<MsTransactionDetail> MsTransactionDetails { get; set; }
        public DbSet<MsTransactionInventory> MsTransactionInventories { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<MsUser> MsUsers { get; set; }
        public DbSet<MsCustomer> MsCustomers { get; set; }
    }
}