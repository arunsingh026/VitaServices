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
    
    public partial class BillReceive
    {
        public System.Guid BillReceiptId { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<System.Guid> BillId { get; set; }
        public Nullable<System.Guid> ReceiptId { get; set; }
    
        public virtual Bill Bill { get; set; }
        public virtual Bill Bill1 { get; set; }
        public virtual Receipt Receipt { get; set; }
        public virtual Receipt Receipt1 { get; set; }
    }
}