//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class DOOR
    {
        public string DOOR_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public string STATUS { get; set; }
        public bool ALLOWSCHEDULES { get; set; }
        public bool ALLOWAPPOINTMENTS { get; set; }
        public string CARRIER_ID { get; set; }
        public string SHIPMENT_ID { get; set; }
        public Nullable<System.DateTime> TIME_ASSIGN { get; set; }
        public Nullable<int> DURATION { get; set; }
        public Nullable<System.DateTime> START_TIME { get; set; }
        public string LABOR { get; set; }
        public string REFERENCE_AREA { get; set; }
        public Nullable<System.DateTime> C_LAST_UPDATED_ { get; set; }
        public string C_LAST_USER_ { get; set; }
        public string C_LAST_MODULE_ { get; set; }
    }
}