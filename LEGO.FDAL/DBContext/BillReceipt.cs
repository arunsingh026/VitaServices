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
    
    public partial class BillReceipt
    {
        public System.Guid BillReceiptId { get; set; }
        public string BillReceiptNo { get; set; }
        public double Amount { get; set; }
        public Nullable<double> Interest { get; set; }
        public Nullable<System.Guid> BillId { get; set; }
        public Nullable<System.Guid> ReceiptId { get; set; }
        public string Description { get; set; }
    
        public virtual Bill Bill { get; set; }
        public virtual Receipt Receipt { get; set; }
    }
}