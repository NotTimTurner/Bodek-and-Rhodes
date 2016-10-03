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
    
    public partial class HOST_ORDERS
    {
        public string EIS_ORDER_ID { get; set; }
        public string STATUS { get; set; }
        public string TYPE { get; set; }
        public System.DateTime ORDER_DATE { get; set; }
        public string CUSTOMER_ID { get; set; }
        public string NAME { get; set; }
        public string ADDRESS_1 { get; set; }
        public string ADDRESS_2 { get; set; }
        public string ADDRESS_3 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string ZIP { get; set; }
        public string PHONE { get; set; }
        public string PURCHASE_ORDER { get; set; }
        public string ORIGINAL_SHIP_MODE { get; set; }
        public Nullable<short> TERMS { get; set; }
        public string COD_INDICATOR { get; set; }
        public Nullable<int> EST_NUM_BOXES { get; set; }
        public string CARRIER_ID { get; set; }
        public Nullable<decimal> FREIGHT { get; set; }
        public Nullable<float> DEPOSIT_AMOUNT { get; set; }
        public string FREIGHT_BILLING_OPTION { get; set; }
        public string EXPEDITE_IND { get; set; }
        public string NOTES { get; set; }
        public Nullable<System.DateTime> IMPORT_TIME { get; set; }
        public string FREIGHT_BILL_TO_ACCOUNT { get; set; }
        public string FREIGHT_BILL_TO_NAME { get; set; }
        public string FREIGHT_BILL_TO_ADDRESS_1 { get; set; }
        public string FREIGHT_BILL_TO_ADDRESS_2 { get; set; }
        public string FREIGHT_BILL_TO_ADDRESS_3 { get; set; }
        public string FREIGHT_BILL_TO_CITY { get; set; }
        public string FREIGHT_BILL_TO_STATE { get; set; }
        public string FREIGHT_BILL_TO_ZIP { get; set; }
        public Nullable<System.DateTime> C_LAST_UPDATED_ { get; set; }
        public string C_LAST_USER_ { get; set; }
        public string C_LAST_MODULE_ { get; set; }
        public string QC_REQUIRED { get; set; }
        public string QC_CODES { get; set; }
        public Nullable<System.DateTime> DELIVER_BY_DATE { get; set; }
        public string EXTERNAL_CARTONIZED { get; set; }
        public Nullable<bool> FIRSTBOXSHIPPED { get; set; }
    }
}