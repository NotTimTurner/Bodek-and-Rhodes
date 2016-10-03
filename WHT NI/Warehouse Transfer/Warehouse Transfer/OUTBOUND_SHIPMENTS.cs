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
    
    public partial class OUTBOUND_SHIPMENTS
    {
        public string SHIPMENT_ID { get; set; }
        public string ORDER_NUMBER { get; set; }
        public string TYPE { get; set; }
        public Nullable<short> STOP { get; set; }
        public Nullable<short> STOP_OF { get; set; }
        public Nullable<short> SEQUENCE { get; set; }
        public string SITE_ID { get; set; }
        public string CUSTOMER_ID { get; set; }
        public string NAME { get; set; }
        public string ADDRESS_1 { get; set; }
        public string ADDRESS_2 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string ZIP { get; set; }
        public string PHONE { get; set; }
        public string PURCHASE_ORDER { get; set; }
        public Nullable<System.DateTime> PURCHASE_ORDER_DATE { get; set; }
        public Nullable<System.DateTime> SCHEDULED_SHIP_DATE { get; set; }
        public Nullable<System.DateTime> ACTUAL_SHIP_DATE { get; set; }
        public string RELEASE_EMPL { get; set; }
        public string ORIGINAL_CARRIER { get; set; }
        public string ORIGINAL_SHIP_MODE { get; set; }
        public string RAIL_ROUTING { get; set; }
        public string CARRIER_ID { get; set; }
        public string SHIP_MODE { get; set; }
        public string EARLY_LATE_CODE { get; set; }
        public string EARLY_LATE_EMPLOYEE { get; set; }
        public Nullable<System.DateTime> EARLY_LATE_DATE { get; set; }
        public string DOOR_ID { get; set; }
        public string TRAILER_INITIALS { get; set; }
        public string TRAILER_NUMBER { get; set; }
        public string TRAILER_SEAL_1 { get; set; }
        public string TRAILER_SEAL_2 { get; set; }
        public string TRAILER_SEAL_3 { get; set; }
        public Nullable<System.DateTime> REQUESTED_ARRIVAL_DATE { get; set; }
        public Nullable<System.DateTime> DELIVERY_DATE { get; set; }
        public Nullable<int> TOTAL_CSN { get; set; }
        public Nullable<float> TOTAL_WEIGHT { get; set; }
        public string LOADER { get; set; }
        public string STATUS { get; set; }
        public string RESERVATION_STATUS { get; set; }
        public string PREPAID_COLLECT { get; set; }
        public string STAGED_LOCATION { get; set; }
        public bool EXCEED_SHIP_BY { get; set; }
        public bool SUBSTITUTION_OVERRIDE { get; set; }
        public bool SPECIAL_HANDLING { get; set; }
        public string NOTES { get; set; }
        public bool ALLOWCOPL { get; set; }
        public string PAYMENT_TERMS { get; set; }
        public string CARTON_TYPE { get; set; }
        public Nullable<decimal> FREIGHT_CHARGE { get; set; }
        public string ALLOCATION_STATUS { get; set; }
        public string COD_INDICATOR { get; set; }
        public Nullable<decimal> CARTON_FREIGHT { get; set; }
        public Nullable<decimal> COD_COST { get; set; }
        public Nullable<int> WAVE_ID { get; set; }
        public Nullable<System.DateTime> WAVE_DATE { get; set; }
        public Nullable<decimal> DEPOSIT_AMOUNT { get; set; }
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
        public string ADDRESS_3 { get; set; }
    }
}
