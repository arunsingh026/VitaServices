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
    
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            this.TransactionRows = new HashSet<TransactionRow>();
            this.BillReceives = new HashSet<BillReceive>();
            this.BillReceives1 = new HashSet<BillReceive>();
            this.TransactionRows1 = new HashSet<TransactionRow>();
            this.BillReceipts = new HashSet<BillReceipt>();
        }
    
        public System.Guid BillId { get; set; }
        public string BillNo { get; set; }
        public System.DateTime BillDate { get; set; }
        public Nullable<System.Guid> MemberId { get; set; }
        public bool InterestApplicable { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.Guid> AccountId { get; set; }
        public Nullable<double> InterestRate { get; set; }
        public Nullable<int> ChargeMethod { get; set; }
        public Nullable<int> CreditMethod { get; set; }
        public Nullable<int> InterestType { get; set; }
        public Nullable<double> MaintananceCharges { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionRow> TransactionRows { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillReceive> BillReceives { get; set; }
        public virtual Ledger Ledger { get; set; }
        public virtual Ledger Ledger1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillReceive> BillReceives1 { get; set; }
        public virtual Ledger Ledger2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionRow> TransactionRows1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillReceipt> BillReceipts { get; set; }
    }
}
