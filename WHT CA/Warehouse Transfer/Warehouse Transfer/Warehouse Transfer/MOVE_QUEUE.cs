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
    
    public partial class MOVE_QUEUE
    {
        public int C_RID_ { get; set; }
        public int INV_RID { get; set; }
        public string TYPE { get; set; }
        public short PRIORITY { get; set; }
        public System.DateTime CREATE_TIME { get; set; }
        public string STATUS { get; set; }
        public string LABELLEVEL { get; set; }
        public string TO_ZONE { get; set; }
        public string TO_LOCATION { get; set; }
        public string FROM_ZONE { get; set; }
        public string FROM_LOCATION { get; set; }
        public Nullable<float> ORIG_QUANTITY_REQUIRED { get; set; }
        public Nullable<float> QUANTITY_REQUIRED { get; set; }
        public Nullable<float> QUANTITY_INTRANSIT { get; set; }
        public string USER_ID_INTRANSIT { get; set; }
        public string VEHICLE_INTRANSIT { get; set; }
        public string SHIPMENT_ID { get; set; }
        public string ORDER_NUMBER { get; set; }
        public Nullable<short> ORDER_LINE { get; set; }
        public Nullable<System.DateTime> C_LAST_UPDATED_ { get; set; }
        public string C_LAST_USER_ { get; set; }
        public string C_LAST_MODULE_ { get; set; }
        public string PAGEFILL2 { get; set; }
        public string PAGEFILL1 { get; set; }
        public string PAGEFILL3 { get; set; }
        public string PAGEFILL4 { get; set; }
        public string PAGEFILL5 { get; set; }
        public string PAGEFILL6 { get; set; }
    }
}
