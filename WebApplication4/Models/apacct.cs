//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class apacct
    {
        public string account { get; set; }
        public string descrip { get; set; }
        public string discount { get; set; }
        public string adjust { get; set; }
        public string checkno { get; set; }
        public Nullable<System.DateTime> lpaydate { get; set; }
        public string currid { get; set; }
        public Nullable<System.DateTime> adddate { get; set; }
        public Nullable<decimal> exadcnt { get; set; }
        public Nullable<bool> used { get; set; }
        public Nullable<decimal> tbalance { get; set; }
        public Nullable<decimal> revrate { get; set; }
        public Nullable<System.DateTime> revdate { get; set; }
        public Nullable<bool> exchfrz { get; set; }
        public string reconstat { get; set; }
        public Nullable<decimal> bbalance { get; set; }
        public Nullable<decimal> ebalance { get; set; }
        public string acctmemo { get; set; }
        public string lckstat { get; set; }
        public string lckuser { get; set; }
        public string lcktime { get; set; }
        public Nullable<System.DateTime> lckdate { get; set; }
        public string adduser { get; set; }
        public string addtime { get; set; }
        public int id_col { get; set; }
    }
}
