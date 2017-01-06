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
    
    public partial class AccountGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccountGroup()
        {
            this.Ledgers = new HashSet<Ledger>();
            this.Ledgers1 = new HashSet<Ledger>();
            this.SpecificGroups = new HashSet<SpecificGroup>();
            this.SpecificGroups1 = new HashSet<SpecificGroup>();
            this.SpecificGroups2 = new HashSet<SpecificGroup>();
            this.SpecificGroups3 = new HashSet<SpecificGroup>();
            this.Ledgers2 = new HashSet<Ledger>();
            this.Ledgers3 = new HashSet<Ledger>();
        }
    
        public System.Guid AccountGroupId { get; set; }
        public string GroupName { get; set; }
        public int ParentGroup { get; set; }
        public int OrderNo { get; set; }
        public bool ShowAccount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ledger> Ledgers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ledger> Ledgers1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecificGroup> SpecificGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecificGroup> SpecificGroups1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecificGroup> SpecificGroups2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecificGroup> SpecificGroups3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ledger> Ledgers2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ledger> Ledgers3 { get; set; }
    }
}
