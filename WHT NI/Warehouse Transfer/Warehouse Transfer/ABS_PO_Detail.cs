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
    
    public partial class ABS_PO_Detail
    {
        public string PURCHASE_ORDER { get; set; }
        public int PO_LINE { get; set; }
        public string PRODUCT_ID { get; set; }
        public Nullable<float> QUANTITY_ORDERED { get; set; }
        public Nullable<float> QUANTITY_RECEIVED { get; set; }
        public string UOM { get; set; }
        public Nullable<System.DateTime> DUE_DATE { get; set; }
        public Nullable<System.DateTime> C_LAST_UPDATED_ { get; set; }
        public string C_LAST_USER_ { get; set; }
        public string C_LAST_MODULE_ { get; set; }
    }
}
