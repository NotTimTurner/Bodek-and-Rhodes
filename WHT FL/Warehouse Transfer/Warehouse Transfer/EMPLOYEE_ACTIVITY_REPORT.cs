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
    
    public partial class EMPLOYEE_ACTIVITY_REPORT
    {
        public int REPORT_ID { get; set; }
        public string USER_ID { get; set; }
        public System.DateTime C_LAST_UPDATED_ { get; set; }
        public float INV_QTY { get; set; }
        public float INV_QTY_OLD { get; set; }
        public string UOM { get; set; }
        public string SHIPMENT_ID { get; set; }
        public string ORDER_NUMBER { get; set; }
        public string TRANTYPE { get; set; }
        public string SUBTYPE { get; set; }
        public string LOCATION_ID { get; set; }
        public string LOCATION_ID_OLD { get; set; }
        public string NAME { get; set; }
        public Nullable<int> ORDER_LINE { get; set; }
        public string Short_Description { get; set; }
        public string COMBO_FIELD { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
    }
}