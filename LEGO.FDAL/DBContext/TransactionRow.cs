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
    
    public partial class TransactionRow
    {
        public System.Guid TransactionId { get; set; }
        public string TransactionNo { get; set; }
        public int DebitCredit { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public double Amount { get; set; }
        public Nullable<bool> OpeningBalance { get; set; }
        public Nullable<System.Guid> AccountId { get; set; }
        public Nullable<System.Guid> ReceiptId { get; set; }
        public Nullable<System.Guid> BillId { get; set; }
        public Nullable<System.Guid> IncomeId { get; set; }
        public Nullable<System.Guid> ExpenseId { get; set; }
        public Nullable<System.Guid> OpeningBalanceId { get; set; }
        public Nullable<System.Guid> InvoiceId { get; set; }
        public Nullable<System.Guid> PaymentId { get; set; }
    
        public virtual Bill Bill { get; set; }
        public virtual Bill Bill1 { get; set; }
        public virtual Expense Expense { get; set; }
        public virtual Expense Expense1 { get; set; }
        public virtual Income Income { get; set; }
        public virtual Income Income1 { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Ledger Ledger { get; set; }
        public virtual Ledger Ledger1 { get; set; }
        public virtual OpeningBalance OpeningBalance1 { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual Receipt Receipt { get; set; }
        public virtual Receipt Receipt1 { get; set; }
    }
}
