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
    
    public partial class AUDIT_INVENTORY_DETAIL
    {
        public int C_RID_ { get; set; }
        public int AUDIT_INVENTORY_RID { get; set; }
        public string INV_ID { get; set; }
        public string INV_BASELABEL { get; set; }
        public string INV_TRACE { get; set; }
        public string PRODUCT_ID { get; set; }
        public string CUSTOMER_ID { get; set; }
        public string CUSTOMER_ID_OLD { get; set; }
        public string SHIPMENT_ID { get; set; }
        public string SHIPMENT_ID_OLD { get; set; }
        public string ORDER_NUMBER { get; set; }
        public string ORDER_NUMBER_OLD { get; set; }
        public Nullable<int> ORDER_LINE { get; set; }
        public Nullable<int> ORDER_LINE_OLD { get; set; }
        public Nullable<int> QC_INCIDENT { get; set; }
        public Nullable<int> QC_INCIDENT_OLD { get; set; }
        public string DEFECT_REASON { get; set; }
        public string DEFECT_REASON_OLD { get; set; }
        public string DEFECT_ID { get; set; }
        public string DEFECT_ID_OLD { get; set; }
        public string STATUS { get; set; }
        public string STATUS_OLD { get; set; }
        public Nullable<System.DateTime> MANUFACTURED_DATE { get; set; }
        public Nullable<System.DateTime> MANUFACTURED_DATE_OLD { get; set; }
        public Nullable<System.DateTime> RECEIPT_DATE { get; set; }
        public Nullable<System.DateTime> RECEIPT_DATE_OLD { get; set; }
        public Nullable<System.DateTime> EXPIRATION_DATE { get; set; }
        public Nullable<System.DateTime> EXPIRATION_DATE_OLD { get; set; }
        public string PRODUCTION_ORDER { get; set; }
        public string PRODUCTION_ORDER_OLD { get; set; }
        public string PRODUCTION_LINE { get; set; }
        public string PRODUCTION_LINE_OLD { get; set; }
        public string PRODUCTION_SHIFT { get; set; }
        public string PRODUCTION_SHIFT_OLD { get; set; }
        public string ADJUSTMENT_CODE { get; set; }
        public string ADJUSTMENT_CODE_OLD { get; set; }
        public Nullable<System.DateTime> C_LAST_UPDATED_ { get; set; }
        public string C_LAST_USER_ { get; set; }
        public string C_LAST_MODULE_ { get; set; }
    }
}
