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
    
    public partial class EnquiryForService
    {
        public System.Guid ServiceId { get; set; }
        public Nullable<System.Guid> EnquiryId { get; set; }
        public int Service { get; set; }
        public double Budget { get; set; }
    
        public virtual Enquiry Enquiry { get; set; }
    }
}
