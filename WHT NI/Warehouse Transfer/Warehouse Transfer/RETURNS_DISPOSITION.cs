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
    
    public partial class RETURNS_DISPOSITION
    {
        public int C_RID_ { get; set; }
        public string RETURN_ID { get; set; }
        public int ORDER_LINE { get; set; }
        public string PRODUCT_ID { get; set; }
        public string QC_CATEGORY { get; set; }
        public string QC_DEFECT { get; set; }
        public Nullable<int> DISPOSITION_CONTAINER_COUNT { get; set; }
        public Nullable<float> DISPOSITION_QUANTITY { get; set; }
        public Nullable<System.DateTime> DISPOSITION_DATE { get; set; }
        public string COMMENTS_1 { get; set; }
        public string COMMENTS_2 { get; set; }
        public Nullable<System.DateTime> DATA1DATE { get; set; }
        public Nullable<int> DATA1NUM { get; set; }
        public string DATA1STR { get; set; }
        public bool LABELS { get; set; }
        public bool INVENTORY { get; set; }
        public Nullable<System.DateTime> C_LAST_UPDATED_ { get; set; }
        public string C_LAST_USER_ { get; set; }
        public string C_LAST_MODULE_ { get; set; }
        public Nullable<System.DateTime> ExportTime_Sys2 { get; set; }
        public Nullable<System.DateTime> ExportTime_Sys1 { get; set; }
        public Nullable<int> EXPORTLOADNUM_SYS2 { get; set; }
    }
}
