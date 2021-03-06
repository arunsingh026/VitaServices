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
    
    public partial class Payment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payment()
        {
            this.InvoicePayments = new HashSet<InvoicePayment>();
            this.TransactionRows = new HashSet<TransactionRow>();
        }
    
        public System.Guid PaymentId { get; set; }
        public string PaymentNo { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public Nullable<System.Guid> PayingAccountId { get; set; }
        public int PaymentMode { get; set; }
        public Nullable<System.DateTime> ChequeDate { get; set; }
        public string ChequeNo { get; set; }
        public string IssuingBank { get; set; }
        public Nullable<System.DateTime> ReconcileDate { get; set; }
        public Nullable<System.DateTime> RevertDate { get; set; }
        public Nullable<double> InterestAmount { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoicePayment> InvoicePayments { get; set; }
        public virtual Ledger Ledger { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionRow> TransactionRows { get; set; }
    }
}
