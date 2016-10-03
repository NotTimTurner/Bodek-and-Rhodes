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
    
    public partial class PRODUCT_MASTER_20091106BAK
    {
        public string PRODUCT_ID { get; set; }
        public string EIS_PRODUCT_ID { get; set; }
        public string UPC_CODE { get; set; }
        public string VENDOR_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public string SHORT_DESCRIPTION { get; set; }
        public string BASE_UOM { get; set; }
        public string PRODUCTION_UOM { get; set; }
        public string STOCK_UOM { get; set; }
        public string RECEIVING_UOM { get; set; }
        public Nullable<float> BASE_UOM_PER_CASELEVEL { get; set; }
        public Nullable<int> CASELEVEL_PER_PALLETTOTE { get; set; }
        public Nullable<int> CASELEVEL_PER_CONTAINER { get; set; }
        public string LOCATION_GROUP { get; set; }
        public string PUTAWAY_ZONE_1 { get; set; }
        public string PUTAWAY_ZONE_2 { get; set; }
        public string PUTAWAY_ZONE_3 { get; set; }
        public string PICK_ZONE_1 { get; set; }
        public string PICK_ZONE_2 { get; set; }
        public string PICK_ZONE_3 { get; set; }
        public string PIECE_PICK_LOCATION { get; set; }
        public string CASELEVEL_PICK_LOCATION { get; set; }
        public string PALLETTOTE_PICK_LOCATION { get; set; }
        public string CONTAINER_PICK_LOCATION { get; set; }
        public string BOL_CLASS { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public string INIT_QC_CATEGORY { get; set; }
        public Nullable<short> SHELF_LIFE { get; set; }
        public Nullable<short> SHIP_BY_WINDOW { get; set; }
        public Nullable<short> CONSOLIDATION_WINDOW { get; set; }
        public Nullable<float> CASELEVEL_WEIGHT { get; set; }
        public Nullable<float> CUBEPERUOM { get; set; }
        public string CUBEUOM { get; set; }
        public bool AUTO_RELEASE { get; set; }
        public Nullable<float> EIS_AVG_UNIT_COST { get; set; }
        public string EIS_SIZE { get; set; }
        public string EIS_MILL_STYLE_NUMBER { get; set; }
        public Nullable<float> EIS_PACKAGE_QTY { get; set; }
        public Nullable<float> EIS_QTY_ONORDER { get; set; }
        public Nullable<float> EIS_QTY_ONHAND { get; set; }
        public Nullable<float> EIS_MILL_PURCHASE_PRICE { get; set; }
        public Nullable<System.DateTime> C_LAST_UPDATED_ { get; set; }
        public string C_LAST_USER_ { get; set; }
        public string C_LAST_MODULE_ { get; set; }
        public Nullable<float> EIS_PIECE_WEIGHT { get; set; }
        public string EIS_COLOR { get; set; }
    }
}
