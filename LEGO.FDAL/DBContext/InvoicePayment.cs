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
    
    public partial class InvoicePayment
    {
        public System.Guid InvoicePaymentId { get; set; }
        public string InvoicePaymentNo { get; set; }
        public double Amount { get; set; }
        public Nullable<double> Interest { get; set; }
        public Nullable<System.Guid> InvoiceId { get; set; }
        public Nullable<System.Guid> PaymentId { get; set; }
        public string Description { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
