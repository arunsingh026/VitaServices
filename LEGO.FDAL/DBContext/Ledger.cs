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
    
    public partial class Ledger
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ledger()
        {
            this.Bills = new HashSet<Bill>();
            this.Bills1 = new HashSet<Bill>();
            this.Bills2 = new HashSet<Bill>();
            this.BillCharges = new HashSet<BillCharge>();
            this.BillCharges1 = new HashSet<BillCharge>();
            this.DebitCreditNoteEntries = new HashSet<DebitCreditNoteEntry>();
            this.DebitCreditNoteEntries1 = new HashSet<DebitCreditNoteEntry>();
            this.DebitCreditNoteEntries2 = new HashSet<DebitCreditNoteEntry>();
            this.Expenses = new HashSet<Expense>();
            this.Expenses1 = new HashSet<Expense>();
            this.Expenses2 = new HashSet<Expense>();
            this.Expenses3 = new HashSet<Expense>();
            this.Incomes = new HashSet<Income>();
            this.Incomes1 = new HashSet<Income>();
            this.Incomes2 = new HashSet<Income>();
            this.Incomes3 = new HashSet<Income>();
            this.Invoices = new HashSet<Invoice>();
            this.Invoices1 = new HashSet<Invoice>();
            this.JournalEntries = new HashSet<JournalEntry>();
            this.JournalEntries1 = new HashSet<JournalEntry>();
            this.TransactionRows = new HashSet<TransactionRow>();
            this.Receipts = new HashSet<Receipt>();
            this.Receipts1 = new HashSet<Receipt>();
            this.OpeningBalances = new HashSet<OpeningBalance>();
            this.TransactionRows1 = new HashSet<TransactionRow>();
            this.OpeningBalances1 = new HashSet<OpeningBalance>();
            this.OpeningBankRecoes = new HashSet<OpeningBankReco>();
            this.OpeningBankRecoes1 = new HashSet<OpeningBankReco>();
            this.OpeningBankRecoes2 = new HashSet<OpeningBankReco>();
            this.OpeningBankRecoes3 = new HashSet<OpeningBankReco>();
            this.Receipts2 = new HashSet<Receipt>();
            this.Receipts3 = new HashSet<Receipt>();
            this.Payments = new HashSet<Payment>();
        }
    
        public System.Guid LedgerId { get; set; }
        public string AccountHead { get; set; }
        public string Abbreviation { get; set; }
        public Nullable<System.Guid> SpecificGroupId { get; set; }
        public Nullable<System.Guid> DebitGroupId { get; set; }
        public Nullable<System.Guid> CreditGroupId { get; set; }
        public Nullable<System.Guid> FlatId { get; set; }
        public Nullable<int> BuildingType { get; set; }
        public string DescriptionInBill { get; set; }
        public Nullable<int> ChargeMethod { get; set; }
        public Nullable<int> BillDisplayOrderNo { get; set; }
        public Nullable<int> CreditOrderNo { get; set; }
        public string Building { get; set; }
        public Nullable<int> LedgerType { get; set; }
        public string Narration { get; set; }
    
        public virtual AccountGroup AccountGroup { get; set; }
        public virtual AccountGroup AccountGroup1 { get; set; }
        public virtual AccountGroup AccountGroup2 { get; set; }
        public virtual AccountGroup AccountGroup3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillCharge> BillCharges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillCharge> BillCharges1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DebitCreditNoteEntry> DebitCreditNoteEntries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DebitCreditNoteEntry> DebitCreditNoteEntries1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DebitCreditNoteEntry> DebitCreditNoteEntries2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expense> Expenses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expense> Expenses1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expense> Expenses2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expense> Expenses3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Income> Incomes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Income> Incomes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Income> Incomes2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Income> Incomes3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JournalEntry> JournalEntries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JournalEntry> JournalEntries1 { get; set; }
        public virtual SpecificGroup SpecificGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionRow> TransactionRows { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipts1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpeningBalance> OpeningBalances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionRow> TransactionRows1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpeningBalance> OpeningBalances1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpeningBankReco> OpeningBankRecoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpeningBankReco> OpeningBankRecoes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpeningBankReco> OpeningBankRecoes2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpeningBankReco> OpeningBankRecoes3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipts2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipts3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual SpecificGroup SpecificGroup1 { get; set; }
    }
}
