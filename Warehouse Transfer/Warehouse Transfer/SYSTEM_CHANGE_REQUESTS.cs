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
    
    public partial class SYSTEM_CHANGE_REQUESTS
    {
        public string CLIENT_CODE { get; set; }
        public int SCR_CODE { get; set; }
        public string CATEGORY { get; set; }
        public string SYNOPSIS { get; set; }
        public int PRIORITY { get; set; }
        public string REQUEST { get; set; }
        public string REQUEST_BY { get; set; }
        public Nullable<System.DateTime> REQUEST_DATE { get; set; }
        public string RESPONSE { get; set; }
        public string RESPONSE_BY { get; set; }
        public Nullable<System.DateTime> RESPONSE_DATE { get; set; }
        public bool ATS_CLOSED { get; set; }
        public string ATS_CLOSED_BY { get; set; }
        public Nullable<System.DateTime> ATS_CLOSED_DATE { get; set; }
        public bool SCR_CLOSED { get; set; }
        public string SCR_CLOSED_BY { get; set; }
        public Nullable<System.DateTime> SCR_CLOSED_DATE { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED { get; set; }
        public string LAST_USER { get; set; }
        public string LAST_MODULE { get; set; }
    }
}