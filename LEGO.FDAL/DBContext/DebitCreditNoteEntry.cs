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
    
    public partial class DebitCreditNoteEntry
    {
        public System.Guid DebitCreditNoteEntryId { get; set; }
        public System.Guid DebitCreditNoteId { get; set; }
        public System.Guid LedgerId { get; set; }
        public int DebitCredit { get; set; }
        public double Principal { get; set; }
        public double Interest { get; set; }
        public string Narration { get; set; }
        public string AccountId { get; set; }
    
        public virtual DebitCreditNote DebitCreditNote { get; set; }
        public virtual DebitCreditNote DebitCreditNote1 { get; set; }
        public virtual DebitCreditNote DebitCreditNote2 { get; set; }
        public virtual Ledger Ledger { get; set; }
        public virtual Ledger Ledger1 { get; set; }
        public virtual Ledger Ledger2 { get; set; }
    }
}
