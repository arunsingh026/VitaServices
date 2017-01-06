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
    
    public partial class OpeningBalance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OpeningBalance()
        {
            this.TransactionRows = new HashSet<TransactionRow>();
        }
    
        public System.Guid OpeningBalanceId { get; set; }
        public System.Guid AccountId { get; set; }
        public int DebitCredit { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<double> PrincipalArrears { get; set; }
        public Nullable<double> InterestArrears { get; set; }
    
        public virtual Ledger Ledger { get; set; }
        public virtual Ledger Ledger1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionRow> TransactionRows { get; set; }
    }
}
