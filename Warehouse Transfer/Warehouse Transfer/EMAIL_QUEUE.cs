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
    
    public partial class EMAIL_QUEUE
    {
        public int RID { get; set; }
        public string RECIPIENT { get; set; }
        public string SUBJECT { get; set; }
        public string MESSAGE { get; set; }
        public string STATUS { get; set; }
        public string STATUS_MESSAGE { get; set; }
        public Nullable<System.DateTime> SENT_TIME { get; set; }
        public string LAST_USER { get; set; }
        public string LAST_MODULE { get; set; }
        public Nullable<System.DateTime> LAST_UPDATED { get; set; }
    }
}
