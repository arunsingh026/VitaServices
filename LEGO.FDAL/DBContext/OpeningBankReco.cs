//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LEGO.FDAL.DBContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class OpeningBankReco
    {
        public System.Guid OpeningBankRecoId { get; set; }
        public System.Guid AccountId { get; set; }
        public string VoucherNo { get; set; }
        public int Type { get; set; }
        public Nullable<System.DateTime> VoucherDate { get; set; }
        public string ChequeNo { get; set; }
        public Nullable<System.DateTime> ChequeDate { get; set; }
        public double Amount { get; set; }
        public string Remark { get; set; }
        public Nullable<System.Guid> PartyId { get; set; }
    
        public virtual Ledger Ledger { get; set; }
        public virtual Ledger Ledger1 { get; set; }
        public virtual Ledger Ledger2 { get; set; }
        public virtual Ledger Ledger3 { get; set; }
    }
}