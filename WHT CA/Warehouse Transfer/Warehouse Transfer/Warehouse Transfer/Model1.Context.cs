﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WarehouseTransfer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WMSEntities : DbContext
    {
        public WMSEntities()
            : base("name=WMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AUDIT_INBOUND> AUDIT_INBOUND { get; set; }
        public virtual DbSet<AUDIT_INBOUND_DETAIL> AUDIT_INBOUND_DETAIL { get; set; }
        public virtual DbSet<AUDIT_INVENTORY> AUDIT_INVENTORY { get; set; }
        public virtual DbSet<AUDIT_INVENTORY_DETAIL> AUDIT_INVENTORY_DETAIL { get; set; }
        public virtual DbSet<Audit_Manifest> Audit_Manifest { get; set; }
        public virtual DbSet<CARRIER> CARRIERS { get; set; }
        public virtual DbSet<CARTON_MASTER> CARTON_MASTER { get; set; }
        public virtual DbSet<EMAIL_GROUPS> EMAIL_GROUPS { get; set; }
        public virtual DbSet<GTIN_XREF> GTIN_XREF { get; set; }
        public virtual DbSet<GTIN_XREF_MASTER> GTIN_XREF_MASTER { get; set; }
        public virtual DbSet<HOST_ORDER_DETAIL> HOST_ORDER_DETAIL { get; set; }
        public virtual DbSet<HOST_ORDERS> HOST_ORDERS { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<LOCATION_CAPACITY> LOCATION_CAPACITY { get; set; }
        public virtual DbSet<LOCATION> LOCATIONS { get; set; }
        public virtual DbSet<LOOKUP_VALUES> LOOKUP_VALUES { get; set; }
        public virtual DbSet<MOVE_QUEUE> MOVE_QUEUE { get; set; }
        public virtual DbSet<PRODUCT_MASTER> PRODUCT_MASTER { get; set; }
        public virtual DbSet<PURCHASE_ORDER_DETAILS> PURCHASE_ORDER_DETAILS { get; set; }
        public virtual DbSet<PURCHASE_ORDERS> PURCHASE_ORDERS { get; set; }
        public virtual DbSet<SYSTEM> SYSTEMs { get; set; }
        public virtual DbSet<TRACELOG> TRACELOGs { get; set; }
        public virtual DbSet<GTIN_BACKUP> GTIN_BACKUP { get; set; }
        public virtual DbSet<MOVE_QUEUE_ARCHIVE> MOVE_QUEUE_ARCHIVE { get; set; }
        public virtual DbSet<MQREPLEN> MQREPLENs { get; set; }
        public virtual DbSet<SYSTEMNEXTRID_AUDINV> SYSTEMNEXTRID_AUDINV { get; set; }
        public virtual DbSet<SYSTEMNEXTRID_AUDINVD> SYSTEMNEXTRID_AUDINVD { get; set; }
        public virtual DbSet<ERRORS_RUNTIME> ERRORS_RUNTIME { get; set; }
        public virtual DbSet<OUTBOUND_SHIPMENT_DETAILS> OUTBOUND_SHIPMENT_DETAILS { get; set; }
        public virtual DbSet<OUTBOUND_SHIPMENTS> OUTBOUND_SHIPMENTS { get; set; }
        public virtual DbSet<SYSTEMNEXTRID> SYSTEMNEXTRIDs { get; set; }
        public virtual DbSet<AUDIT_OUTBOUND> AUDIT_OUTBOUND { get; set; }
        public virtual DbSet<AUDIT_OUTBOUND_DETAIL> AUDIT_OUTBOUND_DETAIL { get; set; }
        public virtual DbSet<INVENTORY_ALLOCATION> INVENTORY_ALLOCATION { get; set; }
        public virtual DbSet<UOM_CONVERSION> UOM_CONVERSION { get; set; }
    }
}