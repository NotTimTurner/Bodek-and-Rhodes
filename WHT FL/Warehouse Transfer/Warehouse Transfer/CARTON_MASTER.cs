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
    
    public partial class CARTON_MASTER
    {
        public string CARTON_TYPE { get; set; }
        public string DESCRIPTION { get; set; }
        public float LENGTH { get; set; }
        public float WIDTH { get; set; }
        public float HEIGHT { get; set; }
        public float UCB_PERCENT { get; set; }
        public float LCB_PERCENT { get; set; }
        public float MAX_WEIGHT { get; set; }
        public float DUNNAGE_WEIGHT { get; set; }
        public bool CONVEYABLE_IND { get; set; }
        public Nullable<System.DateTime> C_LAST_UPDATED_ { get; set; }
        public string C_LAST_USER_ { get; set; }
        public string C_LAST_MODULE_ { get; set; }
    }
}
